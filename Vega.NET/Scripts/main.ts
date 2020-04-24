import "@mapd/connector/dist/browser-connector";
import "vega-webgl-renderer/build/vega-webgl-renderer";

import * as vega from "vega";
import QueryCore from "vega-transform-omnisci-core";

const connection = new (window as any).MapdCon().protocol("https").host("localhost").port("443").dbName("mapd").user("mapd").password("HyperInteractive");

connection.connectAsync().then((session) => {
    // assign session to OmniSci Core transform
    QueryCore.session(session);

    // add core transforms
    (vega as any).transforms["querycore"] = QueryCore;

    const runtime = vega.parse(spec);

    var view = new vega.View(runtime).logLevel(vega.Info).renderer("webgl").initialize(document.querySelector("#view"));

    view.runAsync();

    console.log(table_query);

    // assign view and vega to window so we can debug them
    window["vega"] = vega;
    window["view"] = view;
});

const table = "ParticleSwarmOptimization";

function GetParticlePositionData(name: string): string {
    let query = `( SELECT ` + `Iteration, ` + `SwarmIndex, ` + `Particle, ` + `ParticleName, ` + `ParticlePosition, ` + `ParticleResidual ` + `FROM ${table} ` + `WHERE Iteration = ' + iteration + ' AND ParticleName = \"${name}\" ) AS ${name}Table`;

    return query;
}

const table_query =
    `'SELECT ` +
    `Particle0Table.SwarmIndex AS SwarmIndex, ` +
    `Particle0Table.Particle AS Particle, ` +
    `Particle0Table.ParticlePosition AS Particle0Position, ` +
    `Particle1Table.ParticlePosition AS Particle1Position, ` +
    `Particle2Table.ParticlePosition AS Particle2Position, ` +
    `Particle3Table.ParticlePosition AS Particle3Position, ` +
    `Particle4Table.ParticlePosition AS Particle4Position, ` +
    `Particle5Table.ParticlePosition AS Particle5Position, ` +
    `Particle0Table.ParticleResidual AS ParticleResidual, ` +
    `Particle1Table.ParticleResidual AS ParticleResidual, ` +
    `Particle2Table.ParticleResidual AS ParticleResidual, ` +
    `Particle3Table.ParticleResidual AS ParticleResidual, ` +
    `Particle4Table.ParticleResidual AS ParticleResidual, ` +
    `Particle5Table.ParticleResidual AS ParticleResidual ` +
    `FROM ` +
    `${GetParticlePositionData("Particle0")} ` +
    `INNER JOIN ` +
    `${GetParticlePositionData("Particle1")} ` +
    `ON Particle0Table.Iteration = Particle1Table.Iteration AND Particle0Table.SwarmIndex = Particle1Table.SwarmIndex AND Particle0Table.Particle = Particle1Table.Particle ` +
    `INNER JOIN ` +
    `${GetParticlePositionData("Particle2")} ` +
    `ON Particle1Table.Iteration = Particle2Table.Iteration AND Particle1Table.SwarmIndex = Particle2Table.SwarmIndex AND Particle1Table.Particle = Particle2Table.Particle ` +
    `INNER JOIN ` +
    `${GetParticlePositionData("Particle3")} ` +
    `ON Particle2Table.Iteration = Particle3Table.Iteration AND Particle2Table.SwarmIndex = Particle3Table.SwarmIndex AND Particle2Table.Particle = Particle3Table.Particle ` +
    `INNER JOIN ` +
    `${GetParticlePositionData("Particle4")} ` +
    `ON Particle3Table.Iteration = Particle4Table.Iteration AND Particle3Table.SwarmIndex = Particle4Table.SwarmIndex AND Particle3Table.Particle = Particle4Table.Particle ` +
    `INNER JOIN ` +
    `${GetParticlePositionData("Particle5")} ` +
    `ON Particle4Table.Iteration = Particle5Table.Iteration AND Particle4Table.SwarmIndex = Particle5Table.SwarmIndex AND Particle4Table.Particle = Particle5Table.Particle'`;

// transform to compute the extent
const data = {
    type: "querycore",
    query: {
        signal: table_query
    }
} as any;

const spec: vega.Spec = {
    $schema: "https://vega.github.io/schema/vega/v5.json",
    description: "A scatter plot matrix of table flower data with interactive linked selections.",
    padding: 10,
    width: 1000,
    height: 750,
    config: {
        axis: {
            tickColor: "#ccc"
        }
    },
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
            //   on: [
            //     {
            //       events: {
            //         type: "timer",
            //         throttle: 500,
            //         debounce: 1,
            //       },
            //       update: "iteration < 2 ? iteration + 1 : iteration",
            //     },
            //   ],
        },
        {
            name: "palette",
            value: "RedYellowGreen",
            bind: {
                input: "select",
                options: [
                    "rainbow",
                    "Viridis",
                    "Magma",
                    "Inferno",
                    "Plasma",
                    "DarkBlue",
                    "DarkGold",
                    "DarkGreen",
                    "DarkMulti",
                    "DarkRed",
                    "LightGreyRed",
                    "LightGreyTeal",
                    "LightMulti",
                    "LightOrange",
                    "LightTealBlue",
                    "Blues",
                    "Browns",
                    "Greens",
                    "Greys",
                    "Oranges",
                    "Purples",
                    "Reds",
                    "TealBlues",
                    "Teals",
                    "WarmGreys",
                    "BlueOrange",
                    "BrownBlueGreen",
                    "PurpleGreen",
                    "PinkYellowGreen",
                    "PurpleOrange",
                    "RedBlue",
                    "RedGrey",
                    "RedYellowBlue",
                    "RedYellowGreen",
                    "BlueGreen",
                    "BluePurple",
                    "GoldGreen",
                    "GoldOrange",
                    "GoldRed",
                    "GreenBlue",
                    "OrangeRed",
                    "PurpleBlueGreen",
                    "PurpleBlue",
                    "PurpleRed",
                    "RedPurple",
                    "YellowGreenBlue",
                    "YellowGreen",
                    "YellowOrangeBrown",
                    "YellowOrangeRed"
                ]
            }
        },
        {
            name: "colorBy",
            value: "ParticleResidual",
            bind: {
                input: "select",
                options: ["Particle", "SwarmIndex", "ParticleResidual"]
            }
        },
        { name: "chartSize", value: 125 },
        { name: "chartPad", value: 15 },
        { name: "chartStep", update: "chartSize + chartPad" },
        { name: "width", update: "chartStep * 6" },
        { name: "height", update: "chartStep * 6" },
        {
            name: "cell",
            value: null,
            on: [
                {
                    events: "@cell:mousedown",
                    update: "group()"
                },
                {
                    events: "@cell:mouseup",
                    update: "!span(brushX) && !span(brushY) ? null : cell"
                }
            ]
        },
        {
            name: "brushX",
            value: 0,
            on: [
                {
                    events: "@cell:mousedown",
                    update: "[x(cell), x(cell)]"
                },
                {
                    events: "[@cell:mousedown, window:mouseup] > window:mousemove",
                    update: "[brushX[0], clamp(x(cell), 0, chartSize)]"
                },
                {
                    events: { signal: "delta" },
                    update: "clampRange([anchorX[0] + delta[0], anchorX[1] + delta[0]], 0, chartSize)"
                }
            ]
        },
        {
            name: "brushY",
            value: 0,
            on: [
                {
                    events: "@cell:mousedown",
                    update: "[y(cell), y(cell)]"
                },
                {
                    events: "[@cell:mousedown, window:mouseup] > window:mousemove",
                    update: "[brushY[0], clamp(y(cell), 0, chartSize)]"
                },
                {
                    events: { signal: "delta" },
                    update: "clampRange([anchorY[0] + delta[1], anchorY[1] + delta[1]], 0, chartSize)"
                }
            ]
        },
        {
            name: "down",
            value: [0, 0],
            on: [{ events: "@brush:mousedown", update: "[x(cell), y(cell)]" }]
        },
        {
            name: "anchorX",
            value: null,
            on: [{ events: "@brush:mousedown", update: "slice(brushX)" }]
        },
        {
            name: "anchorY",
            value: null,
            on: [{ events: "@brush:mousedown", update: "slice(brushY)" }]
        },
        {
            name: "delta",
            value: [0, 0],
            on: [
                {
                    events: "[@brush:mousedown, window:mouseup] > window:mousemove",
                    update: "[x(cell) - down[0], y(cell) - down[1]]"
                }
            ]
        },
        {
            name: "rangeX",
            value: [0, 0],
            on: [
                {
                    events: { signal: "brushX" },
                    update: "invert(cell.datum.x.data + 'X', brushX)"
                }
            ]
        },
        {
            name: "rangeY",
            value: [0, 0],
            on: [
                {
                    events: { signal: "brushY" },
                    update: "invert(cell.datum.y.data + 'Y', brushY)"
                }
            ]
        },
        {
            name: "cursor",
            value: "'default'",
            on: [
                {
                    events: "[@cell:mousedown, window:mouseup] > window:mousemove!",
                    update: "'nwse-resize'"
                },
                {
                    events: "@brush:mousemove, [@brush:mousedown, window:mouseup] > window:mousemove!",
                    update: "'move'"
                },
                {
                    events: "@brush:mouseout, window:mouseup",
                    update: "'default'"
                }
            ]
        }
    ],
    data: [
        {
            name: "table",
            transform: [data]
        },
        {
            name: "fields",
            values: ["Particle0Position", "Particle1Position", "Particle2Position", "Particle3Position", "Particle4Position", "Particle5Position"]
        },
        {
            name: "cross",
            source: "fields",
            transform: [
                { type: "cross", as: ["x", "y"] },
                { type: "formula", as: "xscale", expr: "datum.x.data + 'X'" },
                { type: "formula", as: "yscale", expr: "datum.y.data + 'Y'" }
            ]
        }
    ],
    scales: [
        {
            name: "groupx",
            type: "band",
            range: "width",
            domain: { data: "fields", field: "data" }
        },
        {
            name: "groupy",
            type: "band",
            range: [{ signal: "height" }, 0],
            domain: { data: "fields", field: "data" }
        },
        {
            name: "color",
            type: "ordinal",
            domain: { data: "table", field: { signal: `colorBy` } },
            range: { scheme: { signal: "palette" } }
        },

        {
            name: "gradientColor",
            type: "linear",
            domain: [0, 100],
            range: { scheme: { signal: "palette" } }
        },

        {
            name: "Residual",
            domain: { data: "table", field: "ParticleResidual" },
            range: [0, 100]
        },

        {
            name: "Particle0PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle0Position" },
            range: [0, { signal: "chartSize" }]
        },
        {
            name: "Particle1PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle1Position" },
            range: [0, { signal: "chartSize" }]
        },
        {
            name: "Particle2PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle2Position" },
            range: [0, { signal: "chartSize" }]
        },
        {
            name: "Particle3PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle3Position" },
            range: [0, { signal: "chartSize" }]
        },
        {
            name: "Particle4PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle4Position" },
            range: [0, { signal: "chartSize" }]
        },
        {
            name: "Particle5PositionX",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle5Position" },
            range: [0, { signal: "chartSize" }]
        },

        {
            name: "Particle0PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle0Position" },
            range: [{ signal: "chartSize" }, 0]
        },
        {
            name: "Particle1PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle1Position" },
            range: [{ signal: "chartSize" }, 0]
        },
        {
            name: "Particle2PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle2Position" },
            range: [{ signal: "chartSize" }, 0]
        },
        {
            name: "Particle3PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle3Position" },
            range: [{ signal: "chartSize" }, 0]
        },
        {
            name: "Particle4PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle4Position" },
            range: [{ signal: "chartSize" }, 0]
        },
        {
            name: "Particle5PositionY",
            zero: false,
            nice: true,
            domain: { data: "table", field: "Particle5Position" },
            range: [{ signal: "chartSize" }, 0]
        }
    ],
    axes: [
        {
            orient: "left",
            scale: "Particle0PositionY",
            minExtent: 25,
            title: "km",
            tickCount: 5,
            domain: false,
            position: { signal: "5 * chartStep" }
        },
        {
            orient: "left",
            scale: "Particle1PositionY",
            minExtent: 25,
            title: "kF",
            tickCount: 5,
            domain: false,
            position: { signal: "4 * chartStep" }
        },
        {
            orient: "left",
            scale: "Particle2PositionY",
            minExtent: 25,
            title: "kf",
            tickCount: 5,
            domain: false,
            position: { signal: "3 * chartStep" }
        },
        {
            orient: "left",
            scale: "Particle3PositionY",
            minExtent: 25,
            title: "ye",
            tickCount: 5,
            domain: false,
            position: { signal: "2 * chartStep" }
        },
        {
            orient: "left",
            scale: "Particle4PositionY",
            minExtent: 25,
            title: "LF",
            tickCount: 5,
            domain: false,
            position: { signal: "1 * chartStep" }
        },
        {
            orient: "left",
            scale: "Particle5PositionY",
            minExtent: 25,
            title: "Lf",
            tickCount: 5,
            domain: false
        },
        {
            orient: "bottom",
            scale: "Particle0PositionX",
            title: "km",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" }
        },
        {
            orient: "bottom",
            scale: "Particle1PositionX",
            title: "kF",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" },
            position: { signal: "1 * chartStep" }
        },
        {
            orient: "bottom",
            scale: "Particle2PositionX",
            title: "kf",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" },
            position: { signal: "2 * chartStep" }
        },
        {
            orient: "bottom",
            scale: "Particle3PositionX",
            title: "ye",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" },
            position: { signal: "3 * chartStep" }
        },
        {
            orient: "bottom",
            scale: "Particle4PositionX",
            title: "LF",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" },
            position: { signal: "4 * chartStep" }
        },
        {
            orient: "bottom",
            scale: "Particle5PositionX",
            title: "Lf",
            tickCount: 5,
            domain: false,
            offset: { signal: "-chartPad" },
            position: { signal: "5 * chartStep" }
        }
    ],
    // legends: [
    //     {
    //         type: "gradient",
    //         title: "Gradient Legend",
    //         fill: "gradientColor",
    //         direction: "horizontal",
    //         gradientLength: 300,
    //         gradientThickness: 15,
    //         titleOrient: "top",
    //         titleAnchor: null
    //     }
    //],
    // legends: [
    //     {
    //         fill: "color",
    //         // title: "colorBy",
    //         type: "gradient",
    //         gradientLength: 300,
    //         gradientThickness: 12,
    //         direction: "vertical",
    //         titleFontSize: 12,
    //         titlePadding: 4,
    //         gradientLength: { signal: "height" },
    //         columns: 2,
    //         // symbolLimit: 200,
    //         offset: 0
    //         // encode: {
    //         //     symbols: {
    //         //         update: {
    //         //             fillOpacity: { value: 0.5 },
    //         //             stroke: { value: "transparent" }
    //         //         }
    //         //     }
    //         // }
    //     }
    // ],
    marks: [
        {
            type: "rect",
            encode: {
                enter: {
                    fill: { value: "#eee" }
                },
                update: {
                    opacity: { signal: "cell ? 1 : 0" },
                    x: { signal: "cell ? cell.x + brushX[0] : 0" },
                    x2: { signal: "cell ? cell.x + brushX[1] : 0" },
                    y: { signal: "cell ? cell.y + brushY[0] : 0" },
                    y2: { signal: "cell ? cell.y + brushY[1] : 0" },
                    fill: { scale: "color", field: `colorBy` }
                }
            }
        },
        {
            name: "cell",
            type: "group",
            from: { data: "cross" },
            encode: {
                enter: {
                    x: { scale: "groupx", field: "x.data" },
                    y: { scale: "groupy", field: "y.data" },
                    width: { signal: "chartSize" },
                    height: { signal: "chartSize" },
                    fill: { value: "transparent" },
                    stroke: { value: "#ddd" }
                }
            },
            marks: [
                {
                    type: "symbol",
                    from: { data: "table" },
                    interactive: false,
                    encode: {
                        enter: {
                            x: {
                                scale: { parent: "xscale" },
                                field: { datum: { parent: "x.data" } }
                            },
                            y: {
                                scale: { parent: "yscale" },
                                field: { datum: { parent: "y.data" } }
                            },
                            fillOpacity: { value: 0.5 },
                            size: { value: 36 }
                        },
                        update: {
                            fill: [
                                {
                                    test: "!cell || inrange(datum[cell.datum.x.data], rangeX) && inrange(datum[cell.datum.y.data], rangeY)",
                                    scale: "color",
                                    field: { signal: `colorBy` }
                                },
                                { value: "#ddd" }
                            ]
                        }
                    }
                }
            ]
        },
        {
            type: "rect",
            name: "brush",
            encode: {
                enter: {
                    fill: { value: "transparent" }
                },
                update: {
                    x: { signal: "cell ? cell.x + brushX[0] : 0" },
                    x2: { signal: "cell ? cell.x + brushX[1] : 0" },
                    y: { signal: "cell ? cell.y + brushY[0] : 0" },
                    y2: { signal: "cell ? cell.y + brushY[1] : 0" }
                }
            }
        }
    ]
};

// const scatter_plot_spec: vega.Spec = {
//     $schema: "https://vega.github.io/schema/vega/v5.json",
//     autosize: "pad",
//     padding: 5,
//     width: 600,
//     height: 500,
//     signals: [
//         {
//             name: "iteration",
//             value: 0,
//             bind: {
//                 input: "range",
//                 min: 0,
//                 max: 249,
//                 step: 1,
//                 debounce: 10
//             }
//         }
//     ],
//     data: [
//         {
//             name: "table",
//             transform: [data]
//         }
//     ],
//     scales: [
//         {
//             name: "x",
//             type: "linear",
//             round: true,
//             nice: true,
//             zero: true,
//             domain: { data: "table", field: "Particle1Position" },
//             range: "width"
//         },
//         {
//             name: "y",
//             type: "linear",
//             round: true,
//             nice: true,
//             zero: true,
//             domain: { data: "table", field: "Particle0Position" },
//             range: "height"
//         },
//         {
//             name: "color",
//             type: "linear",
//             range: { scheme: "rainbow" },
//             domain: { data: "table", field: "SwarmIndex" },
//             zero: false,
//             nice: true
//         }
//     ],
//     axes: [
//         {
//             scale: "x",
//             grid: true,
//             domain: false,
//             orient: "bottom",
//             tickCount: 5,
//             title: "Particle1Position"
//         },
//         {
//             scale: "y",
//             grid: true,
//             domain: false,
//             orient: "left",
//             titlePadding: 5,
//             title: "Particle0Position"
//         }
//     ],
//     marks: [
//         {
//             name: "marks",
//             type: "symbol",
//             from: { data: "table" },
//             encode: {
//                 enter: {
//                     x: { scale: "x", field: "Particle1Position" },
//                     y: { scale: "y", field: "Particle0Position" },
//                     shape: { value: "circle" },
//                     fill: { scale: "color", field: "SwarmIndex" }
//                 }
//             }
//             // encode: {
//             //     update: {
//             //         x: { scale: "x", field: "Particle1Position" },
//             //         y: { scale: "y", field: "Particle0Position" },
//             //         shape: { value: "circle" },
//             //         strokeWidth: { value: 0 },
//             //         opacity: { value: 1.0 },
//             //         stroke: { value: "#4682b4" },
//             //         fill: { value: "transparent" }
//             //     }
//             // }
//         }
//     ]
// };
