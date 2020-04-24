import * as vega from "vega"
import QueryCore from "vega-transform-omnisci-core"
import "@mapd/connector/dist/browser-connector"

const connection = new (window as any).MapdCon().protocol("https").host("localhost").port("443").dbName("EngineeringDatabase").user("guest").password("guestpassword");

connection.connectAsync().then((session) => {
    // assign session to OmniSci Core transform
    QueryCore.session(session);

    // add core transforms
    (vega as any).transforms["querycore"] = QueryCore;

    const runtime = vega.parse(spec);
    const view = new vega.View(runtime).logLevel(vega.Error).renderer("svg").initialize(document.querySelector("#view"));

    view.runAsync();

    window["vega"] = vega;
    window["view"] = view;
})

const table = "ParticleSwarmOptimization"

const data = {
    type: "querycore",
    query: {
        signal: `'SELECT Particle0Table.SwarmIndex AS SwarmIndex, Particle0Table.ParticlePosition AS Particle0Position, Particle1Table.ParticlePosition AS Particle1Position FROM ( SELECT Iteration, SwarmIndex, Particle, ParticleName, ParticlePosition FROM ${table} WHERE Iteration = ' + iteration + ' AND ParticleName = "Particle0" ) AS Particle0Table INNER JOIN ( SELECT Iteration, SwarmIndex, Particle, ParticleName, ParticlePosition FROM ${table} WHERE Iteration = ' + iteration + ' AND ParticleName = "Particle1" ) AS Particle1Table ON Particle0Table.Iteration = Particle1Table.Iteration AND Particle0Table.SwarmIndex = Particle1Table.SwarmIndex AND Particle0Table.Particle = Particle1Table.Particle'`
    }
} as any

const spec: vega.Spec = {
    $schema: "https://vega.github.io/schema/vega/v5.json",
    autosize: "pad",
    padding: 5,
    width: 600,
    height: 500,
    signals: [
        {
            name: "iteration",
            value: 0,
            bind: {
                input: "range",
                min: 0,
                max: 249,
                step: 1,
                debounce: 10
            }
        }
    ],
    data: [
        {
            name: "table",
            transform: [data]
        }
    ],
    scales: [
        {
            name: "x",
            type: "linear",
            round: true,
            nice: true,
            zero: true,
            domain: { data: "table", field: "Particle1Position" },
            range: "width"
        },
        {
            name: "y",
            type: "linear",
            round: true,
            nice: true,
            zero: true,
            domain: { data: "table", field: "Particle0Position" },
            range: "height"
        },
        {
            name: "color",
            type: "linear",
            range: { scheme: "rainbow" },
            domain: { data: "table", field: "SwarmIndex" },
            zero: false,
            nice: true
        }
    ],
    axes: [
        {
            scale: "x",
            grid: true,
            domain: false,
            orient: "bottom",
            tickCount: 5,
            title: "Particle1Position"
        },
        {
            scale: "y",
            grid: true,
            domain: false,
            orient: "left",
            titlePadding: 5,
            title: "Particle0Position"
        }
    ],
    marks: [
        {
            name: "marks",
            type: "symbol",
            from: { data: "table" },
            encode: {
                enter: {
                    x: { scale: "x", field: "Particle1Position" },
                    y: { scale: "y", field: "Particle0Position" },
                    shape: { value: "circle" },
                    fill: { scale: "color", field: "SwarmIndex" }
                }
            }
            // encode: {
            //     update: {
            //         x: { scale: "x", field: "Particle1Position" },
            //         y: { scale: "y", field: "Particle0Position" },
            //         shape: { value: "circle" },
            //         strokeWidth: { value: 0 },
            //         opacity: { value: 1.0 },
            //         stroke: { value: "#4682b4" },
            //         fill: { value: "transparent" }
            //     }
            // }
        }
    ]
}
