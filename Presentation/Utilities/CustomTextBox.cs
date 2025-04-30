

namespace Presentation.Utilities
{
    public static class CustomTextBox
    {   
        public static void ValidarNumero(this TextBox textBox)
        {
            textBox.KeyPress += (sender, env) =>
            {
                if (char.IsDigit(env.KeyChar))
                    env.Handled = false;
                else
                {
                    if (char.IsControl(env.KeyChar) || env.KeyChar.ToString() == ".")
                        env.Handled = false;
                    else
                        env.Handled = true;
                }
            };
        }
    }
}
