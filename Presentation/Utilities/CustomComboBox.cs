

namespace Presentation.Utilities
{
    public static class CustomComboBox
    {
        public static void InsertarItems(this ComboBox combo, OptionCombo[] items)
        {
            combo.Items.AddRange(items);
            combo.DisplayMember = "Texto";
            combo.ValueMember = "Valor";
            combo.SelectedIndex = 0;
        }

        public static void EstablecerValor(this ComboBox combo, int Valor)
        {
            foreach (OptionCombo opcion in combo.Items)
            {
                if (opcion.Valor == Valor)
                {
                    combo.SelectedItem = opcion;
                    break;
                }
            }
        }
    }
}
