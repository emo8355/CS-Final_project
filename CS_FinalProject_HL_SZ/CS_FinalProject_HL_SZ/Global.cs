﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_FinalProject_HL_SZ
{
    class Global
    {
        public static Database database = new Database();
        public static Login loginScreen = new Login();
        public static SignUp signUpScreen = new SignUp();
        public static Control controlScreen = new Control();
        public static CategoryScreen categoryScreen = new CategoryScreen();
        public static Authors authorsScreen = new Authors();
        public static Books bookScreen = new Books();
        public static LendBooks lendBookScreen = new LendBooks();
        public static ReturnBooks returnBookScreen = new ReturnBooks();
    }
}
