using Shopping.Dao;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Service
{
    public class indexpro : BaseService
    {
        public List<indexModel> indexproduct()
        {
            indexDao indexDao = new indexDao();
            List<indexModel> index = indexDao.indexproduct();
            return index;
        }

    }
}