# Livraria

Este projeto � uma aplica��o web desenvolvida com Blazor, utilizando .NET 10.0, voltada para a gest�o de uma livraria. O sistema � modularizado em m�ltiplos projetos para melhor organiza��o e escalabilidade.

## Estrutura do Projeto

- **Livraria.Brazor**: Projeto principal da interface web, constru�do com Blazor. Respons�vel pela intera��o com o usu�rio.
- **Livraria.Application**: Camada de aplica��o, contendo regras de neg�cio, DTOs, mapeamentos e servi�os.
- **Livraria.Domain**: Define as entidades, abstra��es e enums do dom�nio da livraria.
- **Livraria.Infrastructure**: Implementa a persist�ncia de dados e reposit�rios.
- **Livraria.CrossCutting**: Camada de integra��o entre as demais, facilitando a comunica��o e compartilhamento de recursos.

## Principais Tecnologias

- **.NET 10.0**
- **Blazor WebAssembly**
- **Bootstrap** para estiliza��o
- **Inje��o de Depend�ncia** para reposit�rios e navega��o

## Como Executar

1. Certifique-se de ter o .NET 10 SDK instalado.
2. Restaure os pacotes e depend�ncias (__Gerenciador de Pacotes NuGet__).
3. Execute o projeto `Livraria.Brazor` (__Definir como projeto de inicializa��o__).
4. Acesse a aplica��o via navegador em `https://localhost:5001` (ou porta configurada).

## Estrutura de Pastas

- `Livraria.Brazor/Components`: Componentes Blazor reutiliz�veis.
- `Livraria.Application/DTOs`: Objetos de transfer�ncia de dados.
- `Livraria.Domain/Entities`: Entidades do dom�nio.
- `Livraria.Infrastructure/Repositories`: Implementa��es de acesso a dados.

## Contribui��o

1. Fa�a um fork do reposit�rio.
2. Crie uma branch (`git checkout -b feature/nome-da-feature`).
3. Commit suas altera��es (`git commit -am 'Adiciona nova feature'`).
4. Fa�a push para a branch (`git push origin feature/nome-da-feature`).
5. Abra um Pull Request.

## Licen�a

Este projeto est� sob a licen�a MIT.

---

Projeto criado para fins de estudo e demonstra��o de arquitetura moderna com Blazor e .NET.