﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSBP.Common.Models.ViewModels
{
    public class Response
    {
        public bool IsSuccess {get; set; }
        public string? Message { get; set; }
        public Object? Result { get; set; }     
    }
}
