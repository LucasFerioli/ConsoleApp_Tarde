@model List<Produto>

<div class="row">
    <div class="col-md-12">
        <h1>Lista de produtos</h1>
    </div>
</div>

<div class="row">
    <div class="col-md-12">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nome</th>
                    <th>Preço</th>
                </tr>
            </thead>
            <tbody>
                @foreach (var produto in Model)
                {
                    <tr>
                        <td>@produto.Id</td>
                        <td>@produto.Nome</td>
                        <td>@produto.Preco</td>
                    </tr>
                }
            </tbody>
        </table>
    </div>
</div>
