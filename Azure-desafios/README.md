# Criando Máquinas Virtuais Azure

## Nessa aula, aprendemos o que são SLA's: SLA da Azure garante que:

### Seus recursos na nuvem estarão disponíveis: A Microsoft se compromete a manter seus serviços em funcionamento por uma determinada porcentagem de tempo, geralmente muito alta (próxima de 99,9%).

### Você receberá créditos se o SLA não for cumprido: Caso a disponibilidade do serviço caia abaixo do nível prometido, a Microsoft oferece créditos que podem ser utilizados para pagar por outros serviços da Azure.

# Configurando uma instância de Banco de Dados na Azure

## Configuração do BD na Azure

---

## 1. Escolha o Tipo de Instância:

### banco de Dados SQL do Azure: Ideal para aplicações com carga de trabalho relacional, oferecendo alta disponibilidade e escalabilidade.

### Instância Gerenciada de SQL: Para migrar bancos de dados SQL Server existentes para a nuvem com pouca ou nenhuma modificação.

### Cosmos DB: Um banco de dados NoSQL multi-modelo, altamente escalável e com latência ultra baixa, ideal para aplicações com grandes volumes de dados e alta concorrência.

---

## 2. Crie um Grupo de Recursos:

### Um grupo de recursos é um contêiner lógico que permite organizar seus recursos da Azure.

### Por que criar um grupo de recursos? Facilita o gerenciamento, provisionamento e exclusão de recursos.

---

## 3. Configure a Instância:

### Nome: Escolha um nome descritivo e único para sua instância.

### Tier: Selecione o nível de serviço que melhor atende às suas necessidades (Básico, Padrão, Premium).

### Tamanho de Computação: Defina a quantidade de vCores e memória RAM.

### Armazenamento: Escolha o tipo de armazenamento (SSD ou HDD) e o tamanho.

### Rede: Configure as regras de firewall para permitir o acesso à instância.

---

## 4. Crie um Banco de Dados:

### Dentro da instância, crie um ou mais bancos de dados.

### Defina o collation: Escolha o collation adequado para o seu idioma e requisitos de ordenação.

---

## 5. Configure a Autenticação:

### SQL Authentication: Use um nome de usuário e senha.

### Azure Active Directory: Integre a autenticação com o Azure AD para maior segurança.

---

## 6. Conecte-se à Instância:

### Utilize ferramentas como o SQL Server Management Studio (SSMS), Azure Data Studio ou drivers ODBC/ADO.NET para se conectar à sua instância.
