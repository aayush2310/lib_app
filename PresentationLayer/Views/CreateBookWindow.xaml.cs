﻿using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for CreateBookWindow.xaml
    /// </summary>
    public partial class CreateBookWindow : Window
    {
        public BookDTO Book { get; set; }
        public CreateBookWindow()
        {
            InitializeComponent();

            //genreComboBox.SelectedValuePath = nameof(GenreDTO.GenreId)

            Book = new BookDTO();
            this.DataContext = Book;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
