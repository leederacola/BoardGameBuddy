using BoardGameBuddy.Data;
using BoardGameBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace BoardGameBuddy.Controllers
{
    public class HomeController : Controller
    {
        public BoardGameRepository boardGameRepository = null;
        public GameLibrary gameLibrary = null; 

        public HomeController ()
        {
            boardGameRepository = new BoardGameRepository();
            gameLibrary = new GameLibrary();  
        }
      

/** Start Methods **/  
     
        public ActionResult Index()   
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        
         public ViewResult GameRepository()
        //! returns view Home/GameLibiary
        //! Action Linker located in Index view
        {
            var gameList = boardGameRepository.GetBoardGames();
            return View(gameList);
        }

        public ViewResult GameLibrary()
        {
            //addAll()
            //gameLibrary.addAll(boardGameRepository.GetBoardGames());
            //clearGames()
            //gameLibrary.clearGames();
            //addIndex(int)
            gameLibrary.addIndex(boardGameRepository.GetBoardGames(), 1);
            gameLibrary.addIndex(boardGameRepository.GetBoardGames(), 4);
            gameLibrary.addIndex(boardGameRepository.GetBoardGames(), 3);
            //removeAt
            //gameLibrary.removeAt(1);
            //clearGames()
            //gameLibrary.clearGames();

            var library = gameLibrary.GetBoardGames();
            return View(library);
        }


        public ActionResult Detail(int? id)//nullable var id
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var boardGame = boardGameRepository.GetBoardGame((int)id);
            return View(boardGame);
        }
    }
}