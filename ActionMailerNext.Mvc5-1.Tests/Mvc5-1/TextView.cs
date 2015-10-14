﻿using System.IO;
using System.Web.Mvc;

namespace ActionMailerNext.Mvc5_1.Tests
{
    public class TextView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            writer.Write("TextView");
        }
    }
}