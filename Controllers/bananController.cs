using System.Collections.Generic;
using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers{
    [Route("api/banan")]
    [ApiController]
    public class bananController: ControllerBase{
        private readonly IbananRepo _bananRepo;
        public bananController(IbananRepo ibanan){
            _bananRepo = ibanan;
        }
        //private readonly bananRepo _bananRepo = new bananRepo();
        
        //GET  api/banan/
        [HttpGet]
        public IEnumerable<banan> GetAllbanan(){
            return _bananRepo.GetAppbanan();
        }


        //GET  api/banan/{id}
        [HttpGet("{id}")]
        public ActionResult GetbananByID(int id){
            return Ok(_bananRepo.GetBananByID(id));
        }
    }
}