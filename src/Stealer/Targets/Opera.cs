﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stealer.Targets
{
    class Opera : AbstractFile
    {
        public override bool IsExist()
        {
            throw new NotImplementedException();
        }

        public override byte[] GetFile()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Opera";
        }
    }
}
