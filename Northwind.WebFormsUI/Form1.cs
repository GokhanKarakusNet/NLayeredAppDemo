using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategoryId.DataSource = _categoryService.GetAll();
            cbxAddCategoryId.DisplayMember = "CategoryName";
            cbxAddCategoryId.ValueMember = "CategoryId";

            cbxUpdateCategoryId.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryId.DisplayMember = "CategoryName";
            cbxUpdateCategoryId.ValueMember = "CategoryId";


        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategoryId.SelectedValue),
                    ProductName = tbxAddProductName.Text,
                    QuantityPerUnit = tbxAddProductQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddProductUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxAddProductStock.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Kaydedildi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                ProductName = tbxUpdateProductName.Text,
                QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateProductUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUpdateProductStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxUpdateCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateProductUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateProductStock.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
            } 
            LoadProducts();
            MessageBox.Show("Ürün Silindi");
        }
    }
}
