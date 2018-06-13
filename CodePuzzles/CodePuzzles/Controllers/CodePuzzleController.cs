using CodePuzzleBusinessServices;
using CodePuzzleBusinessServices.Interfaces;
using CodePuzzles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodePuzzles.Controllers
{
    public class CodePuzzleController : Controller
    {
        //Key word processor interface initialization
        IKeyWordProcessor _IKeyWordProcessor;
        //Shape class initialization
        Shape shape;

        /// <summary>
        /// Code puzzles index view load
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Natural language shape generator";
            CodePuzzleViewModel model = new CodePuzzleViewModel();
            shape = new Shape();
            model.Shape = shape;
            return View(model);
        }

        /// <summary>
        /// Code puzzles index view submit
        /// </summary>
        /// <param name="model">Code puzzles view model</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(CodePuzzleViewModel model)
        {
            try
            {
                _IKeyWordProcessor = new KeyWordProcessor();
                shape = new Shape();

                //Strip the user input
                string strippedString = _IKeyWordProcessor.StripUserInput(model.ShapeDescription);
                //Get the shape object
                shape = _IKeyWordProcessor.IdentifyShape(strippedString);

                //Assign shape object to view model
                model.Shape = shape;
                                
            }
            catch(Exception ex)
            {
                shape = new Shape();
                model.Shape = shape;
                ViewBag.Message = "Error occurred!";
            }

            return View(model);
        }
    }
}