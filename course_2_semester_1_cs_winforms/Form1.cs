using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using static course_2_semester_1_cs_winforms.UninterruptivlePowerSupply;

namespace course_2_semester_1_cs_winforms
{
    public partial class MainForm : Form
    {
        private readonly Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> byManufacturer =
            (x, y) => x.manufacturer.CompareTo(y.manufacturer) > 0;
        private readonly Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> byBrand =
            (x, y) => x.brand.CompareTo(y.brand) > 0;
        private readonly Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> byCapacity =
            (x, y) => x.capacity > (y.capacity);
        private PowerSupplies powerSupplies;
        private readonly int count = 50;
        private Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> currentSortParam;
        private SortMethod currentSortMethod;
        private ComparingValue currentComparingParam;
        private Graphics graphics;

        public MainForm()
        {
            currentSortParam = byManufacturer;
            currentSortMethod = SortMethod.Direct;
            powerSupplies = new PowerSupplies(count);
            InitializeComponent();
            graphics = SortingContainerPanel.CreateGraphics();

            LoadNewPowerSupplies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Buttons

        private void SortButton_Click(object sender, EventArgs e)
        {
            long time;
            switch (currentSortMethod)
            {
                case SortMethod.Direct:
                    time = powerSupplies.SelectionSort(currentSortParam, RedrawPowerSupplies);
                    MessageBox.Show($"Прошло миллисекунд: {time}.");
                    break;
                case SortMethod.Bubble:
                    time = powerSupplies.BubbleSort(currentSortParam, RedrawPowerSupplies);
                    MessageBox.Show($"Прошло миллисекунд: {time}.");
                    break;
                case SortMethod.Shaker:
                    time = powerSupplies.ShakerSort(currentSortParam, RedrawPowerSupplies);
                    MessageBox.Show($"Прошло миллисекунд: {time}.");
                    break;
                case SortMethod.Shell:
                    time = powerSupplies.ShellSort(currentSortParam, RedrawPowerSupplies);
                    MessageBox.Show($"Прошло миллисекунд: {time}.");
                    break;
            }
        }

        private void MixButton_Click(object sender, EventArgs e)
        {
            LoadNewPowerSupplies();
        }

        // Sorting params

        private void ManufacturerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortParam = byManufacturer;
            ChangeComparingParameter(ComparingValue.Manufacturer);
            currentComparingParam = ComparingValue.Manufacturer;
            RedrawPowerSupplies();
        }

        private void BrandRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortParam = byBrand;
            ChangeComparingParameter(ComparingValue.Brand);
            currentComparingParam = ComparingValue.Brand;
            RedrawPowerSupplies();
        }

        private void CapacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortParam = byCapacity;
            ChangeComparingParameter(ComparingValue.Capacity);
            currentComparingParam = ComparingValue.Capacity;
            RedrawPowerSupplies();
        }

        // Sorting methods

        private void DirectSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortMethod = SortMethod.Direct;
        }

        private void BubbleSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortMethod = SortMethod.Bubble;
        }

        private void ShakerSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortMethod = SortMethod.Shaker;
        }

        private void ShellSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSortMethod = SortMethod.Shell;
        }

        private void LoadNewPowerSupplies()
        {
            powerSupplies = new PowerSupplies(count);
            ChangeComparingParameter(currentComparingParam);
            RedrawPowerSupplies();
        }

        private void RedrawPowerSupplies()
        {
            var currentPixel = 10;
            for (int index = 0; index < count; index++)
            {
                var clearPen = new Pen(Color.White, 14);
                var clear1 = new Point(currentPixel, 404);
                var clear2 = new Point(currentPixel, 0);
                graphics.DrawLine(clearPen, clear1, clear2);

                var p = new Pen(Color.Black, 12);
                var point1 = new Point(currentPixel, 404);
                var point2 = new Point(currentPixel, (int)(404f - ((float)powerSupplies[index].GetComparingValue()) / 1000f * 404));
                graphics.DrawLine(p, point1, point2);
                currentPixel += 17;
            }
        }

        private void SortingContainerPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var currentPixel = 10;
                for (int index = 0; index < count; index++)
                {
                    var clearPen = new Pen(Color.White, 14);
                    var clear1 = new Point(currentPixel, 404);
                    var clear2 = new Point(currentPixel, 0);
                    g.DrawLine(clearPen, clear1, clear2);

                    var p = new Pen(Color.Black, 12);
                    var point1 = new Point(currentPixel, 404);
                    var point2 = new Point(currentPixel, (int)(404f - ((float)powerSupplies[index].capacity) / 1000f * 404));
                    g.DrawLine(p, point1, point2);
                    currentPixel += 17;
                }
            }
        }

        private void ChangeComparingParameter(ComparingValue value)
        {
            for (int i = 0; i < count; i++)
            {
                powerSupplies[i].SetComparingValue(value);
            }
        }
    }



    enum SortMethod
    {
        Direct,
        Bubble,
        Shaker,
        Shell
    }
}
