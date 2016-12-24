using System;
using System.Web.Mvc;
using DjikstraLib;

namespace Djikstra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var graph = new Graph<string>(GetGraphForAssignment());
            graph.DjikstraShortestPath(0,17);
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}