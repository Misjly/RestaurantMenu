using Object_2.Business_layer;
using Object_2.Data_access_layer;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace Object_2.Presentation_layer
{
    public partial class ProductForm : Form
    {
        private Catalog _catalog;
        private Business_layer.Menu _menu = new Business_layer.Menu();
        private NumberFormatInfo _setPrecision = new NumberFormatInfo { NumberDecimalDigits = 2, NumberDecimalSeparator = "," };

        public ProductForm(User user)
        {
            InitializeComponent();

            UserNameLabel.Text = user.Name;
            AgeInfoLabel.Text = user.Age.ToString();
            WeightInfoLabel.Text = user.Weight.ToString();
            HeightInfoLabel.Text = user.Height.ToString();
            ActivityInfoLabel.Text = user.DailyActivity.ToString();
            double ARM = 0;
            switch (user.DailyActivity)
            {
                case Activity.Low:
                    {
                        ARM = 1.2;
                        break;
                    }
                case Activity.Normal:
                    {
                        ARM = 1.375;
                        break;
                    }
                case Activity.Average:
                    {
                        ARM = 1.55;
                        break;
                    }
                case Activity.High:
                    {
                        ARM = 1.725;
                        break;
                    }
            }
            CaloriesRateInfoLabel.Text = (ARM + (447.593 + 9.247 * user.Weight + 3.098 * user.Height - 4.330 * user.Age)).ToString();

            Serializer<Catalog> serializer = new Serializer<Catalog>();
            _catalog = serializer.Deserialize();

            CatalogListView.View = View.Details;
            CatalogListView.Columns.Add("Name", 250);
            CatalogListView.Columns.Add("Gramms", 50);
            CatalogListView.Columns.Add("Protein", 50);
            CatalogListView.Columns.Add("Fats", 50);
            CatalogListView.Columns.Add("Carbs", 50);
            CatalogListView.Columns.Add("Calories", 50);

            foreach (var category in _catalog)
            {
                var group = new ListViewGroup(category.Name, HorizontalAlignment.Left);
                foreach (var product in category.Products)
                {
                    var item = new ListViewItem(product.Name, group);
                    item.SubItems.Add(product.Gramms.ToString());
                    item.SubItems.Add(product.StringProtein);
                    item.SubItems.Add(product.StringFats);
                    item.SubItems.Add(product.StringCarbs);
                    item.SubItems.Add(product.StringCalories);
                    item.Tag = product;
                    CatalogListView.Items.Add(item);
                }
                CatalogListView.Groups.Add(group);
            }

            MenuListView.View = View.Details;

            MenuListView.Columns.Add("Name", 250);
            MenuListView.Columns.Add("Gramms", 50);
            MenuListView.Columns.Add("Protein", 50);
            MenuListView.Columns.Add("Fats", 50);
            MenuListView.Columns.Add("Carbs", 50);
            MenuListView.Columns.Add("Calories", 50);

            ListViewGroup menuGroup = new ListViewGroup("Breakfast", HorizontalAlignment.Center);
            MenuListView.Groups.Add(menuGroup);
            var menuItem = new ListViewItem("", menuGroup);
            menuItem.SubItems.Add("");
            menuItem.SubItems.Add("");
            menuItem.SubItems.Add("");
            menuItem.SubItems.Add("");
            menuItem.SubItems.Add("");
            MenuListView.Items.Add(menuItem);
            MenuListView.View = View.Details;

            menuGroup = new ListViewGroup("Lunch", HorizontalAlignment.Center);
            MenuListView.Groups.Add(menuGroup);
            var menuItem1 = new ListViewItem("", menuGroup);
            menuItem1.SubItems.Add("");
            menuItem1.SubItems.Add("");
            menuItem1.SubItems.Add("");
            menuItem1.SubItems.Add("");
            menuItem1.SubItems.Add("");
            MenuListView.Items.Add(menuItem1);

            menuGroup = new ListViewGroup("Dinner", HorizontalAlignment.Center);
            MenuListView.Groups.Add(menuGroup);
            var menuItem2 = new ListViewItem("", menuGroup);
            menuItem2.SubItems.Add("");
            menuItem2.SubItems.Add("");
            menuItem2.SubItems.Add("");
            menuItem2.SubItems.Add("");
            menuItem2.SubItems.Add("");
            MenuListView.Items.Add(menuItem2);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Serializer<Catalog> serializer = new Serializer<Catalog>();
            serializer.Serialize(_catalog);
            MessageBox.Show("Catalog was successfully saved");
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogListView.Items.Remove(CatalogListView.SelectedItems[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Select item");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" ||
                CategoryTextBox.Text == "" ||
                GrammsTextBox.Text == "" ||
                ProteinTextBox.Text == "" ||
                FatsTextBox.Text == "" ||
                CarbsTextBox.Text == "" ||
                CaloriesTextBox.Text == "")
            {
                MessageBox.Show("Fill the info");
                return;
            }

            try
            {
                double temp = double.Parse(GrammsTextBox.Text, _setPrecision);
                GrammsTextBox.Text = temp.ToString("F", _setPrecision);

                temp = double.Parse(ProteinTextBox.Text, _setPrecision);
                ProteinTextBox.Text = temp.ToString("F", _setPrecision);

                temp = double.Parse(FatsTextBox.Text, _setPrecision);
                FatsTextBox.Text = temp.ToString("F", _setPrecision);

                temp = double.Parse(CarbsTextBox.Text, _setPrecision);
                CarbsTextBox.Text = temp.ToString("F", _setPrecision);

                int.Parse(CaloriesTextBox.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show($"Info was in wrong form:{Environment.NewLine}" +
                    $"Protein, Fats and Carbs are fractional numbers with comma{Environment.NewLine}" +
                    "Gramms and Calories are integers");
                return;
            }
            var item = new ListViewItem(NameTextBox.Text);
            item.SubItems.Add(GrammsTextBox.Text);
            item.SubItems.Add(ProteinTextBox.Text);
            item.SubItems.Add(FatsTextBox.Text);
            item.SubItems.Add(CarbsTextBox.Text);
            item.SubItems.Add(CaloriesTextBox.Text);

            bool group_exists = false;
            foreach (ListViewGroup group in CatalogListView.Groups)
            {
                if (group.Header == CategoryTextBox.Text)
                {
                    item.Group = group;
                    group_exists = true;
                    break;
                }
            }
            if (!group_exists)
            {
                ListViewGroup group = new ListViewGroup(CategoryTextBox.Text);
                CatalogListView.Groups.Add(group);
                item.Group = group;
            }

            CatalogListView.Items.Add(item);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int gramms;
            try
            {
                gramms = int.Parse(GrammsTextBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Info was in wrong form:{Environment.NewLine}Gramms is integer");
                return;
            }

            try
            {

                if (MenuListView.SelectedItems[0].SubItems[0].Text == "")
                {
                    MessageBox.Show("Select the item");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select the item");
                return;
            }

            double oldGramms = double.Parse(MenuListView.SelectedItems[0].SubItems[1].Text, _setPrecision);

            double total = double.Parse(TotalInfoLabel.Text, _setPrecision);
            total -= ((Product)MenuListView.SelectedItems[0].Tag).Calories;

            double ratio = gramms / oldGramms;
            var product = new Product()
            {
                Name = ((Product)MenuListView.SelectedItems[0].Tag).Name,
                Gramms = gramms,
                Protein = ((Product)MenuListView.SelectedItems[0].Tag).Protein * ratio,
                Fats = ((Product)MenuListView.SelectedItems[0].Tag).Fats * ratio,
                Carbs = ((Product)MenuListView.SelectedItems[0].Tag).Carbs * ratio,
                Calories = ((Product)MenuListView.SelectedItems[0].Tag).Calories * ratio,
            };
            MenuListView.SelectedItems[0].Tag = product;

            switch(MenuListView.SelectedItems[0].Group.Header)
            {
                case "Breakfast":
                    {
                        for (int i = 0; i < _menu.Breakfast.Products.Count; i++)
                        {
                            if (_menu.Breakfast.Products[i].Name == product.Name)
                            {
                                _menu.Breakfast.Products[i] = product;
                                break;
                            }
                        }
                        break;
                    }
                case "Lunch":
                    {
                        for (int i = 0; i < _menu.Lunch.Products.Count; i++)
                        {
                            if (_menu.Lunch.Products[i].Name == product.Name)
                            {
                                _menu.Lunch.Products[i] = product;
                                break;
                            }
                        }
                        break;
                    }
                case "Dinner":
                    {
                        for (int i = 0; i < _menu.Dinner.Products.Count; i++)
                        {
                            if (_menu.Dinner.Products[i].Name == product.Name)
                            {
                                _menu.Dinner.Products[i] = product;
                                break;
                            }
                        }
                        break;
                    }
            }



            MenuListView.SelectedItems[0].SubItems[1].Text = gramms.ToString();
            MenuListView.SelectedItems[0].SubItems[2].Text = product.StringProtein;
            MenuListView.SelectedItems[0].SubItems[3].Text = product.StringFats;
            MenuListView.SelectedItems[0].SubItems[4].Text = product.StringCarbs;
            MenuListView.SelectedItems[0].SubItems[5].Text = product.StringCalories;

            total += ((Product)MenuListView.SelectedItems[0].Tag).Calories;
            TotalInfoLabel.Text = total.ToString("F", _setPrecision);
        }

        private void DeleteButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuListView.SelectedItems[0].SubItems[0].Text == "")
                {
                    MessageBox.Show("Select the item");
                    return;
                }

                switch(MenuListView.SelectedItems[0].Group.Header)
                {
                    case "Breakfast":
                        {
                            _menu.Breakfast.Products.Remove((Product)MenuListView.SelectedItems[0].Tag);
                            break;
                        }
                    case "Lunch":
                        {
                            _menu.Lunch.Products.Remove((Product)MenuListView.SelectedItems[0].Tag);
                            break;
                        }
                    case "Dinner":
                        {
                            _menu.Dinner.Products.Remove((Product)MenuListView.SelectedItems[0].Tag);
                            break;
                        }
                }

                double total = double.Parse(TotalInfoLabel.Text, _setPrecision);
                total -= ((Product)MenuListView.SelectedItems[0].Tag).Calories;
                TotalInfoLabel.Text = total.ToString("F", _setPrecision);

                MenuListView.SelectedItems[0].Remove();
            }
            catch (Exception)
            {
                MessageBox.Show("Select the item");
            }
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            Serializer<Business_layer.Menu> serializer = new Serializer<Business_layer.Menu>();
            serializer.Serialize(_menu);
            MessageBox.Show("Menu was successfully saved");
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = (ListViewItem)CatalogListView.SelectedItems[0].Clone();
            item.BackColor = Color.White;


            switch (MenuListBox.SelectedItem)
            {
                case "Breakfast":
                    {
                        item.Group = MenuListView.Groups[0];
                        break;
                    }
                case "Lunch":
                    {
                        item.Group = MenuListView.Groups[1];
                        break;
                    }
                case "Dinner":
                    {
                        item.Group = MenuListView.Groups[2];
                        break;
                    }
            }


            foreach (ListViewItem lvi in MenuListView.Items)
            {
                if (lvi.Text == item.Text && item.Group == lvi.Group)
                    return;
            }

            switch (MenuListBox.SelectedItem)
            {
                case "Breakfast":
                    {
                        _menu.Breakfast.Products.Add((Product)CatalogListView.SelectedItems[0].Tag);
                        break;
                    }
                case "Lunch":
                    {
                        _menu.Lunch.Products.Add((Product)CatalogListView.SelectedItems[0].Tag);
                        break;
                    }
                case "Dinner":
                    {
                        _menu.Dinner.Products.Add((Product)CatalogListView.SelectedItems[0].Tag);
                        break;
                    }
            }

            MenuListView.Items.Add(item);

            double total = double.Parse(TotalInfoLabel.Text, _setPrecision);
            total += ((Product)item.Tag).Calories;
            TotalInfoLabel.Text = total.ToString("F", _setPrecision);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem viewItem in CatalogListView.Items)
            {
                viewItem.BackColor = Color.White;
            }

            foreach (ListViewItem viewItem in CatalogListView.Items)
            {
                if (viewItem.Text.Contains(SearchTextBox.Text))
                    viewItem.BackColor = Color.Green;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem viewItem in CatalogListView.Items)
            {
                viewItem.BackColor = Color.White;
            }
        }
    }
}
