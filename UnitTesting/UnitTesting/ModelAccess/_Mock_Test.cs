﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTesting.ModelAccess
{
    public class checkEmployee
    {
        public virtual Boolean checkEmp()
        {
            throw new NotImplementedException();
        }
    }

    public class processEmployee
    {
        public Boolean insertEmployee(checkEmployee objtmp)
        {
            objtmp.checkEmp();
            return true;
        }
    }
}