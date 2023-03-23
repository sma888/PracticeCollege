using CarDealership.DbEntites;
using CarDealership.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarDealership.ViewModel
{
    class AddManagerWindowViewModel
    {
        private Manager _manager;
        private MainWindow main;

        public void btnSave_Click(object sender, RoutedEventArgs e)
        {
          
                try
                {
                    var validateResult = ValidateEntity();

                    if (validateResult != null)
                    {
                        MessageBox.Show(validateResult.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    DbSingileton.Db_s.Manager.Add(_manager);

                    DbSingileton.Db_s.SaveChanges();

                    MessageBox.Show("Данные успешно сохранены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            
        }

        private StringBuilder ValidateEntity()
        {
           var errors = new StringBuilder();

            //if (_manager != null)
            //{
            //    if (string.IsNullOrEmpty(_manager.Name))
            //    {
            //        errors.AppendLine("Поле наименование товара не может быть пустым!");
            //    }

            //    if (_manager.Value <= 0)
            //    {
            //        errors.AppendLine("Некорректное количество товара!");
            //    }

            //    if (_manager.Price <= 0)
            //    {
            //        errors.AppendLine("Некорректная цена!");
            //    }
            //}

            return errors;
        }
    }
}

