using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

using Vega.Schema;
using Vega.Charts;

namespace Vega.Test
{
    internal class Program
    {
        private static IEnumerable<Specification> ExampleSpecifications
        {
            get
            {
                yield return Specification.FromJson(Examples.airport_connections_vg);
                yield return Specification.FromJson(Examples.annual_precipitation_vg);
                yield return Specification.FromJson(Examples.annual_temperature_vg);
                yield return Specification.FromJson(Examples.arc_diagram_vg);
                yield return Specification.FromJson(Examples.area_chart_vg);
                yield return Specification.FromJson(Examples.bar_chart_vg);
                yield return Specification.FromJson(Examples.barley_trellis_plot_vg);
                yield return Specification.FromJson(Examples.beeswarm_plot_vg);
                yield return Specification.FromJson(Examples.binned_scatter_plot_vg);
                yield return Specification.FromJson(Examples.box_plot_vg);
                yield return Specification.FromJson(Examples.brushing_scatter_plots_vg);
                yield return Specification.FromJson(Examples.budget_forecasts_vg);
                yield return Specification.FromJson(Examples.circle_packing_vg);
                yield return Specification.FromJson(Examples.clock_vg);
                yield return Specification.FromJson(Examples.connected_scatter_plot_vg);
                yield return Specification.FromJson(Examples.contour_plot_vg);
                yield return Specification.FromJson(Examples.county_unemployment_vg);
                yield return Specification.FromJson(Examples.crossfilter_flights_vg);
                yield return Specification.FromJson(Examples.density_heatmaps_vg);
                yield return Specification.FromJson(Examples.distortion_comparison_vg);
                yield return Specification.FromJson(Examples.donut_chart_vg);
                yield return Specification.FromJson(Examples.dorling_cartogram_vg);
                yield return Specification.FromJson(Examples.dot_plot_vg);
                yield return Specification.FromJson(Examples.earthquakes_vg);
                yield return Specification.FromJson(Examples.edge_bundling_vg);
                yield return Specification.FromJson(Examples.error_bars_vg);
                yield return Specification.FromJson(Examples.falkensee_population_vg);
                yield return Specification.FromJson(Examples.force_directed_layout_vg);
                yield return Specification.FromJson(Examples.global_development_vg);
                yield return Specification.FromJson(Examples.grouped_bar_chart_vg);
                yield return Specification.FromJson(Examples.heatmap_vg);
                yield return Specification.FromJson(Examples.histogram_null_values_vg);
                yield return Specification.FromJson(Examples.histogram_vg);
                yield return Specification.FromJson(Examples.horizon_graph_vg);
                yield return Specification.FromJson(Examples.hypothetical_outcome_plots_vg);
                yield return Specification.FromJson(Examples.interactive_legend_vg);
                yield return Specification.FromJson(Examples.job_voyager_vg);
                yield return Specification.FromJson(Examples.line_chart_vg);
                yield return Specification.FromJson(Examples.loess_regression_vg);
                yield return Specification.FromJson(Examples.nested_bar_chart_vg);
                yield return Specification.FromJson(Examples.overview_plus_detail_vg);
                yield return Specification.FromJson(Examples.pacman_vg);
                yield return Specification.FromJson(Examples.parallel_coordinates_vg);
                yield return Specification.FromJson(Examples.pi_monte_carlo_vg);
                yield return Specification.FromJson(Examples.pie_chart_vg);
                yield return Specification.FromJson(Examples.population_pyramid_vg);
                yield return Specification.FromJson(Examples.probability_density_vg);
                yield return Specification.FromJson(Examples.projections_vg);
                yield return Specification.FromJson(Examples.quantile_dot_plot_vg);
                yield return Specification.FromJson(Examples.quantile_quantile_plot_vg);
                yield return Specification.FromJson(Examples.radar_chart_vg);
                yield return Specification.FromJson(Examples.radial_plot_vg);
                yield return Specification.FromJson(Examples.radial_tree_layout_vg);
                yield return Specification.FromJson(Examples.regression_vg);
                yield return Specification.FromJson(Examples.reorderable_matrix_vg);
                yield return Specification.FromJson(Examples.scatter_plot_null_values_vg);
                yield return Specification.FromJson(Examples.scatter_plot_vg);
                yield return Specification.FromJson(Examples.stacked_area_chart_vg);
                yield return Specification.FromJson(Examples.stacked_bar_chart_vg);
                yield return Specification.FromJson(Examples.stock_index_chart_vg);
                yield return Specification.FromJson(Examples.sunburst_vg);
                yield return Specification.FromJson(Examples.time_units_vg);
                yield return Specification.FromJson(Examples.timelines_vg);
                yield return Specification.FromJson(Examples.top_k_plot_with_others_vg);
                yield return Specification.FromJson(Examples.top_k_plot_vg);
                yield return Specification.FromJson(Examples.tree_layout_vg);
                yield return Specification.FromJson(Examples.treemap_vg);
                yield return Specification.FromJson(Examples.u_district_cuisine_vg);
                yield return Specification.FromJson(Examples.violin_plot_vg);
                yield return Specification.FromJson(Examples.volcano_contours_vg);
                yield return Specification.FromJson(Examples.watch_vg);
                yield return Specification.FromJson(Examples.weekly_temperature_vg);
                yield return Specification.FromJson(Examples.wheat_and_wages_vg);
                yield return Specification.FromJson(Examples.wheat_plot_vg);
                yield return Specification.FromJson(Examples.wind_vectors_vg);
                yield return Specification.FromJson(Examples.word_cloud_vg);
                yield return Specification.FromJson(Examples.world_map_vg);
                yield return Specification.FromJson(Examples.zoomable_scatter_plot_vg);
                yield return Specification.FromJson(Examples.zoomable_world_map_vg);
            }
        }

        [STAThread]
        private static void Main(string[] args)
        {
            foreach(Specification exampleSpecification in ExampleSpecifications)
            {
                VegaChart chart = new VegaChart(exampleSpecification.Description,
                                                exampleSpecification);

                chart.ShowInBrowser();
            }
        }
    }
}
