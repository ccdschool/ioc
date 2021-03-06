﻿using Nancy;
using Nancy.ModelBinding;
using without_ioc.viewmodel;

namespace without_ioc
{
    public class AddModule : NancyModule
    {
        private readonly Interactors _interactors;

        public AddModule(Interactors interactors) {
            _interactors = interactors;
            
            Get["/"] = _ => View["add"];

            Post["sum"] = _ => {
                var addVm = this.Bind<AddVM>();
                var sumVm = _interactors.Add(addVm);
                return View["sum", sumVm];
            };
        }
    }
}