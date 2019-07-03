﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileManager.Models;
using FileManager.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FileManager.Pages.Account
{
    public class ResetPasswordConfirmationModel : PageModel
    {
        private readonly UserManager<User> _userManager;


        public ResetPasswordConfirmationModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ResetPasswordConfirmationViewModel ResetPasswordConfirmationViewModel { get; set; }

        public Guid userId { get; set; }

        public string resetPasswordConfirmationToken { get; set; }

        public IActionResult OnGetResetPassword(Guid userId, string token)
        {
            this.userId = userId;
            resetPasswordConfirmationToken = token;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    User user = await _userManager.FindByIdAsync(ResetPasswordConfirmationViewModel.UserId.ToString());

                    if (user != null)
                    {
                        IdentityResult result = await _userManager.ResetPasswordAsync(user,
                            ResetPasswordConfirmationViewModel.ResetPasswordConfirmationToken,
                            ResetPasswordConfirmationViewModel.Password);

                        if (result.Succeeded)
                        {
                            return Content("ResetPasswordConfirmation is succeeded");
                        }

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return Page();
        }
    }
}