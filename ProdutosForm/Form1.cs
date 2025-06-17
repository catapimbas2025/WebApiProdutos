namespace ProdutosForm
{
    public partial class Form1 : Form
    {
        private readonly ApiClient _apiClient;
        private BindingSource _produtosBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            //SUBSTITUA PELA URL DA SUA API
            _apiClient = new ApiClient("http://localhost:5001");

            //CONFIGURAR DATAGRIDVIEW
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produtosBindingSource;

            //CONFIGURAR EVENTOS
            //btnCarregar.Click +=  btnCarregar_Click;
            //btnAdicionar.Click += btnAdicionar_Click;
            //btnAtualizar.Click += btnAtualizar_Click;
            //btnRemover.Click +=   btnRemover_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                var produtos = await _apiClient.GetProdutosAsync();
                _produtosBindingSource.DataSource = produtos;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoProduto = new Produto
                {
                    Nome = txtNome.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    Estoque = int.Parse(txtEstoque.Text)

                };
                var produtoAdicionado = await _apiClient.AddProdutoAsync(novoProduto);
                MessageBox.Show($"Produto adicionado com ID: {produtoAdicionado.Id}");

                await CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto:{ex.Message}");
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Produto produtoSelecionado)
            {
                try
                {
                    produtoSelecionado.Nome = txtNome.Text;
                    produtoSelecionado.Preco = decimal.Parse(txtPreco.Text);
                    produtoSelecionado.Estoque = int.Parse(txtEstoque.Text);

                    await _apiClient.UpdateProdutoAsync(produtoSelecionado.Id, produtoSelecionado);
                    MessageBox.Show("Produto atualizado com sucesso!");

                    await CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Erro ao atualizar produto: {ex.Message}");
                }
            }
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Produto produtoSelecionado)
            {
                try
                {
                    await _apiClient.DeleteProdutoAsync(produtoSelecionado.Id);
                    MessageBox.Show("Produt removido com sucesso!");

                    await CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover produto:{ex.Message}");
                }
            }
        }

        private async Task CarregarProdutos()
        {
            var produtos = await _apiClient.GetProdutosAsync();
            _produtosBindingSource.DataSource = produtos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Produto produtoSelecionado)
            {
                txtNome.Text = produtoSelecionado.Nome;
                txtPreco.Text = produtoSelecionado.Preco.ToString();
                txtEstoque.Text = produtoSelecionado.Estoque.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           txtNome.Clear();
           txtPreco.Clear();
           txtEstoque.Clear();
                
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        
        //}
    }
}
