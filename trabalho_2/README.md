# trabalho_2 — Filmes (Resumo rápido)

Tentamos — infelizmente somos sem inteligência.  
Este README descreve de forma direta o que foi feito parcialmente no projeto e o que ainda precisa ser corrigido.

## Estado atual (parcialmente implementado)
- Aplicação WinForms `Form1` com CRUD básico para a tabela `filmes` (MySQL).
- Campos manipulados: `id`, `titulo`, `genero`, `classificacao`, `duracao`.
- Navegação: primeiro, próximo, anterior, último.
- Operações: adicionar, alterar, excluir, confirmar, cancelar.
- Busca por título com `DataGridView` (`dtgfilmes`) e formulário de busca `frmbusca`.
- Formulário `Compras` criado (aberto pelo botão `btnComprar`).
- Conexão com banco centralizada em `DBComun.Conectar()` (arquivo `db.cs`).
 