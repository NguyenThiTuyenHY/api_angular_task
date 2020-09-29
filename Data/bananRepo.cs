using System.Collections.Generic;
using Models;
using System.Linq;

namespace Data{
    public class bananRepo:IbananRepo
    {
        public IEnumerable<banan> GetAppbanan()
        {
            var ds = new List<banan>(){
                new banan{id=0,soghe=12,tinhtrang=1,makh =null},
                new banan{id=1,soghe=12,tinhtrang=1,makh =null},
                new banan{id=2,soghe=12,tinhtrang=1,makh =null},
                new banan{id=3,soghe=12,tinhtrang=1,makh =null},
                new banan{id=4,soghe=12,tinhtrang=1,makh =null},
                new banan{id=5,soghe=12,tinhtrang=1,makh =null}
            };
            return ds;
        }

        public bool DeletebananByID(int id){
            var ds = new List<banan>(){
                new banan{id=0,soghe=12,tinhtrang=1,makh =null},
                new banan{id=1,soghe=12,tinhtrang=1,makh =null},
                new banan{id=2,soghe=12,tinhtrang=1,makh =null},
                new banan{id=3,soghe=12,tinhtrang=1,makh =null},
                new banan{id=4,soghe=12,tinhtrang=1,makh =null},
                new banan{id=5,soghe=12,tinhtrang=1,makh =null}
            };
            banan ba = ds.SingleOrDefault(x=>x.id == id);
            if(ba==null)
                return false;
            else{
                ds.Remove(ba);
                return true;
            } 
        }

        public banan GetBananByID(int id)
        {
            return new banan{id=0,soghe=12,tinhtrang=1,makh =null};
        }
    }
}