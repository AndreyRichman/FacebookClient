﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DPDesktopFacebook
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
            // hello
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Form1());
          }
     }
}
