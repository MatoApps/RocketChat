﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RocketChat
{
    public class SessionContextDto
    {
        public string Token { get; set; }
        public string UserId { get; set; }
        public bool IsAuthorized { get; set; }

        public SessionContextDto()
        {
            IsAuthorized = false;
        }
    }
}
