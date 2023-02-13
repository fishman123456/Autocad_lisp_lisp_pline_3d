﻿using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Autocad_lisp_lisp_pline_3d
{
    public interface IDialogService
    {
        void ShowMessage(string message);   // показ сообщения
        string FilePath { get; set; }   // путь к выбранному файлу
        bool OpenFileDialog();  // открытие файла
        bool SaveFileDialog();  // сохранение файла
    }

    internal class open_file
    {
        public class DefaultDialogService : IDialogService
        {
            public string FilePath { get; set; }

            public bool OpenFileDialog()
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    FilePath = openFileDialog.FileName;
                    return true;
                }
                return false;
            }

            public bool SaveFileDialog()
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    FilePath = saveFileDialog.FileName;
                    return true;
                }
                return false;
            }

            public void ShowMessage(string message)
            {
                MessageBox.Show(message);
            }
        }
    }
}
