﻿using SirketOtomasyonAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SirketOtomasyonAspNet
{
    public partial class SiteMaster : MasterPage
    {
        ASPNETSirketEntities db = new ASPNETSirketEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = db.Birimlers.ToList();
            Repeater1.DataSource = model;
            Repeater1.DataBind();

        }
    }
}