using PacoteExtra.Models;
using PacoteExtra.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace PacoteExtra.ViewModels
{
    public class BaseViewModel
    {
        public virtual void EventoAoAparecer() { }
        public virtual void EventoAoDesaparecer() { }
        public virtual bool EventoNoClickBotaoVoltar()
        {
            return true;
        }
    }
}
