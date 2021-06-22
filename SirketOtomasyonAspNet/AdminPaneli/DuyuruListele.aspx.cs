﻿using SirketOtomasyonAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SirketOtomasyonAspNet.AdminPaneli
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ASPNETSirketEntities db = new ASPNETSirketEntities();


        protected void Page_Load(object sender, EventArgs e)
        {
            var model = db.Duyurulars.ToList();
            Repeater1.DataSource = model;
            Repeater1.DataBind();
        }
    }
}