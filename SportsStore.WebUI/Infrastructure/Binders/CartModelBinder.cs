﻿using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // get the cart from the session
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            }

            // create the Cart if there isn't one in the session data
            if (cart == null)
            {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
            }
            
            // return the cart
            return cart;
        }
    }
}