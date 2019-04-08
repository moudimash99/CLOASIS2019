/* ------------------------------------------------------------------------------
 *
 *  # C3.js - bars and pies
 *
 *  Demo setup of bars, pies and chart combinations
 *
 *  Version: 1.0
 *  Latest update: August 1, 2015
 *
 * ---------------------------------------------------------------------------- */

$(function () {
    



     

    // Resize chart on sidebar width change
    $(".sidebar-control").on('click', function() {
        pie_chart.resize();
        donut_chart.resize();
        bar_chart.resize();
        bar_stacked_chart.resize();
        combined_chart.resize();
        scatter_chart.resize();
    });
});