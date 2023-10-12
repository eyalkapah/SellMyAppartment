using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppartment.Maui.Data;
internal interface IDialogService
{
    Task<bool> DisplayConfirm(string title, string message, string accept, string cancel);
}
