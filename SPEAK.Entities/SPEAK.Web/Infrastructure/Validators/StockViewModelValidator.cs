﻿using FluentValidation;
using SPEAK.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPEAK.Web.Infrastructure.Validators
{
    public class StockViewModelValidator : AbstractValidator<StockViewModel>
    {
        public StockViewModelValidator()
        {
            RuleFor(s => s.ID).GreaterThan(0)
                .WithMessage("Invalid stock item");

            RuleFor(s => s.UniqueKey).NotEqual(Guid.Empty)
                .WithMessage("Invalid stock item");
        }
    }
}