# Livraria

Este projeto é uma aplicação web desenvolvida com Blazor, utilizando .NET 10.0, voltada para a gestão de uma livraria. O sistema é modularizado em múltiplos projetos para melhor organização e escalabilidade.

## Estrutura do Projeto

- **Livraria.Brazor**: Projeto principal da interface web, construído com Blazor. Responsável pela interação com o usuário.
- **Livraria.Application**: Camada de aplicação, contendo regras de negócio, DTOs, mapeamentos e serviços.
- **Livraria.Domain**: Define as entidades, abstrações e enums do domínio da livraria.
- **Livraria.Infrastructure**: Implementa a persistência de dados e repositórios.
- **Livraria.CrossCutting**: Camada de integração entre as demais, facilitando a comunicação e compartilhamento de recursos.

## Principais Tecnologias

- **.NET 10.0**
- **Blazor WebAssembly**
- **Bootstrap** para estilização
- **Injeção de Dependência** para repositórios e navegação

## Como Executar

1. Certifique-se de ter o .NET 10 SDK instalado.
2. Restaure os pacotes e dependências (__Gerenciador de Pacotes NuGet__).
3. Execute o projeto `Livraria.Brazor` (__Definir como projeto de inicialização__).
4. Acesse a aplicação via navegador em `https://localhost:5001` (ou porta configurada).

## Estrutura de Pastas

- `Livraria.Brazor/Components`: Componentes Blazor reutilizáveis.
- `Livraria.Application/DTOs`: Objetos de transferência de dados.
- `Livraria.Domain/Entities`: Entidades do domínio.
- `Livraria.Infrastructure/Repositories`: Implementações de acesso a dados.

## Contribuição

1. Faça um fork do repositório.
2. Crie uma branch (`git checkout -b feature/nome-da-feature`).
3. Commit suas alterações (`git commit -am 'Adiciona nova feature'`).
4. Faça push para a branch (`git push origin feature/nome-da-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está sob a licença MIT.

---

Projeto criado para fins de estudo e demonstração de arquitetura moderna com Blazor e .NET.