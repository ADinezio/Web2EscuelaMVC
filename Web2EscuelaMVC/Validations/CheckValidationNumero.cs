using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web2EscuelaMVC.Validations
{
    public class CheckValidationNumero:ValidationAttribute
    {
        public CheckValidationNumero() 
        {
            ErrorMessage = "El numero debe ser mayor a 100";
        }
        public override bool IsValid(object value)
        {
            int number =(int) value;
            if(number <100) return false;
            else return true;
        }
    }
}