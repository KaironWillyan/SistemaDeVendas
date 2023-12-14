
# Trabalho de Análise e Projeto de Sistemas

**Aluno:** Kairon Willyan Ribeiro de Melo  
**Matrícula:** 2022111TADS0258

---

## Descrição do Projeto

Sistema de pagamento utilizando C#

## Tecnologias Utilizadas

- Linguagem de Programação: [C#]
- Framework: [Entity FrameWork]
- Banco de Dados: [MySql]
- Arquitetura: [MVC]

##Diagrama do Projeto
![Imagem do Projeto](./imagens/kaironAps.png)


## Instalação e Configuração

1. **Clone o Repositório:**
   ```bash
   git clone git@github.com:KaironWillyan/SistemaDeVendas.git
   ```

2. **Instale as Dependências:**
   ```bash
   cd kairon
   
   dotnet restore

   dotnet build
   ```

3. **Configurações Adicionais:**
   - Coloque sua senha do banco de dados no arquivo [appsettings.json](./kairon/appsettings.json)

4. **Crie o banco e faça as migrate:**

    ```bash
        dotnet ef migrations nome_da_migrate

        dotnet ef database update
    ```

## Como Executar

Após cada mudança significativa que for feita, use:
   ```bash
   
   dotnet restore

   dotnet build
   ```

para executar o projeto, basta apenas o comando:

```bash
dotnet run
```

Acesse o aplicativo em [http://localhost:5115](http://localhost:5115) ou na porta que aparecer em seu terminal.

##Funcionamento

####Telas:

    - Cliente:
![Imagem tela Cliente](./imagens/clientes.png)

    - Vendedores

![Imagem tela vendedores](./imagens/vendedores.png)

    - Transportadoras

![Imagem tela transportadoras](./imagens/transportadoras.png)

    - Marcas

![Imagem tela marcas](./imagens/marcas.png)

    - Produtos

![Imagem tela produtos](./imagens/produtos.png)

    - Itens

![Imagem tela itens](./imagens/itens.png)

    - Pagamentos com Cartão

![Imagem tela pagamento com cartao](./imagens/pagamento_com_cartao.png)

    - Pagamentos em Cheque

![Imagem tela pagamento emcheque](./imagens/pagamento_com_cheque.png)

    - Notas de Venda

![Imagem tela notas de venda](./imagens/notas_de_vendas.png)

    - Pagamentos

![Imagem tela Pagamentos](./imagens/pagamentos.png)
