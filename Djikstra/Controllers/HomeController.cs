using System.Web.Mvc;
using DjikstraLib;
using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;
using System;

namespace Djikstra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var graph = new Graph<string>(GetGraphForAssignment());
            ViewBag.shortestPath = graph.DjikstraShortestPath(0,17);

            //var getStartProcessQuery = new GetStartProcessQuery();
            //var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
            //var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);

            // GraphGeneration can be injected via the IGraphGeneration interface

            //var wrapper = new GraphGeneration(getStartProcessQuery,
            //                                  getProcessStartInfoQuery,
            //                                  registerLayoutPluginCommand);

            //var bytes = wrapper.GenerateGraph("digraph{s -> v; v -> g; g -> s; g -> f; f -> o; o -> r; r -> m; m -> a; a -> t; t -> f;}", Enums.GraphReturnType.Svg);
            //var viewModel = System.Text.Encoding.UTF8.GetString(bytes);
            //ViewBag.Data = viewModel;

            return View();
        }

        /// <summary>
        /// Graf je sličan onome koji je zadan u zadatku za vježbu, osim što
        /// su negativne vrijednosti pretvorene u pozitivne vrijednosti
        /// jednakog iznosa.
        /// </summary>
        /// <returns></returns>
        private int[,] GetGraphForAssignment()
        {
            int[,] adjMatrix = new int[18, 18]
            {
                { 0,2,6,12,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,3,0,9,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,2,0,0,4,0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,3,0,1,3,2,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,5,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,2,0,0,0,0,9,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,0,0 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,6 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3 },
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }
            };
            return adjMatrix;
        }
    }
}