using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class GenerationMaze
    {
        public int GridWidth { get; } = 30;
        public int GridHeight { get; } = 25;
        
        public GenerationMaze()
        {
            InitializeComponent();
            DataContext = this;

            var cells = new List<Cell>();
            var random = new Random();
            
            foreach (var _ in Enumerable.Range(0, GridWidth * GridHeight))
            {
                cells.Add(new Cell {Color = random.Next(0, 10) > 5 ? Brushes.Red : Brushes.Black});
            }
            
            ItemsControl.ItemsSource = cells;
        }
    }

    public class Cell
    {
        public Brush Color { get; set; }
    }
}