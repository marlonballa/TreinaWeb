## O que é o ASP.NET Core

    O ASP.NET Core é uma versão do ASP.NET para a plataforma .NET Core. Só que antes de conhecê-lo precisamos voltar um pouco no tempo.

    Em 2002, no lançamento da versão 1.0 do .NET Framework, a Microsoft lançou com esta plataforma o ASP.NET, como um sucessor da tecnologia ASP ( Active Server Pages).

    Por se tratar de uma extensão do .NET Framework, assim como ele, no início o ASP.NET possuía poucos recursos. Suportava todas as linguagens de programação compatíveis com a plataforma .NET, mas ainda era muito limitado.

    Replicando o desenvolvimento Desktop na web
    No seu lançamento, o ASP.NET trouxe o modelo de aplicação Web Forms (ASP.NET Web Forms), cujo objetivo era replicar o desenvolvimento Desktop em uma aplicação web.

    Em 2002, o desenvolvimento Desktop possuía ferramentas como Delphi e Visual Basic, que permitiam que uma tela fosse criada com o arrastar de controles. Desta forma, o desenvolvedor não precisava se preocupar com a codificação dos componentes da interface, apenas com a lógica de negócios.

    Replicando isso na web, o ASP.NET Web Forms permitia que os desenvolvedores criassem interfaces web arrastando componentes. O ASP.NET se encarregaria de criar o HTML, CSS e JavaScript da página, e o desenvolvedor poderia focar na lógica de negócio da aplicação.

    Olhando em retrospecto, na época esta foi uma boa solução, pois ajudou os desenvolvedores Desktop migrarem para o desenvolvimento web. Entretanto, o HTML gerado pelo ASP.NET tinha pouca legibilidade, hoje seria considerado um código muito poluído, por isso ao logo do tempo o Web Forms entrou em desuso e hoje está descontinuado.

    ## Padrões de projetos vem ao resgate
    Para melhorar a qualidade das aplicações ASP.NET, em 2009 foi lançado o modelo de aplicação MVC (ASP.NET MVC), cujo objetivo era aplicar o padrão de projetos MVC. Neste tipo de aplicação, os componentes são separados em três camadas lógicas:

    Model (camada de negócio);
    View (camada de apresentação);
    Controller (camada de controle).
    Um model representa o estado de um aspeto particular da aplicação. O controller lida com as interações e alterações do model para refletir o estado da aplicação e passa essas informações para a view. A view recebe as informações do controller e as exibe para o usuário.

    Não possuindo mais o recurso de arrastar componentes para criar as páginas, mas isoladas na camada view, o ASP.NET MVC permitia que um desenvolvedor front-end pudesse focar na criação das páginas, enquanto outro lidasse com a lógica de negócio das camadas model e controller.

    ## A constante busca pela evolução

    Buscando uma evolução constante, ao longo do tempo foram lançados vários recursos ao ASP.NET, como: Web API, que permite criar APIs; Razor, uma template engine; ASP.NET AJAX, que facilita a adição de Ajax em aplicações ASP.NET; entre outros.

    Nesta procura por evolução, a Microsoft notou que a comunidade poderia ajudá-la, assim, em 2012 decidiu abrir o código fonte do ASP.NET (entre outros produtos). E trabalhando em conjunto com a comunidade nas atualizações do ASP.NET, notou que a plataforma necessitava de muitas modificações que não poderiam ser aplicadas na versão existente, assim nasceu o ASP.NET Core.

    ## Então surge o ASP.NET Core

    Sucessor do ASP.NET, o ASP.NET Core é um framework open-source, multiplataforma, criado pela Microsoft e a comunidade. Leve, rápido e modular, funciona em conjunto com o .NET Core.

    Lançado em 2016, mesmo sendo um sucessor do ASP.NET, o ASP.NET Core foi criado totalmente do zero, para que não precisasse se preocupar com código legado permitindo assim seguir o padrão de desenvolvimento web moderno.

    Assim como outras plataformas, o ASP.NET Core é totalmente modular, recursos podem ser adicionados via pacotes Nuget. O que permitiu que a plataforma fosse mais performática que seu antecessor. Além disso, não necessita de uma IDE específica, todo desenvolvimento pode ser feito via linha de comando. O que permite que uma aplicação criada em uma plataforma possa ser movida para outra, sem a perda de nenhum recurso ou funcionalidade.

    Devido a todo seu poder, caso necessite criar uma aplicação web, não deixe de dar uma olhada no ASP.NET Core.

## O que é HTTP, Request, GET, POST, Response, 200, 404?

    Aprenda nesse post de forma simples e direta os principais conceitos HTTP que sempre teve dúvida, porém nunca teve coragem de perguntar.

    Nosso objetivo nesse post não é entrar 100% na parte técnica do protocolo HTTP, mas sim apresentar uma visão prática dele. Caso tenha interesse em se aprofundar aconselho dar uma olhada no nosso curso específico:

    Antes de falar sobre conceitos que fazem parte do HTTP, precisamos entender o que é o HTTP em si.

    O que é HTTP
    O HTTP é um protocolo de comunicação. Através dele o cliente e o servidor conseguem se comunicar, seguindo um conjunto de regras bem definidas (por isso chamamos de protocolo). Por exemplo, se estivermos falando de uma aplicação web, o cliente é o navegador, ele envia um pedido para o servidor web usando o protocolo HTTP, com base nesse pedido, se tudo estiver correto, o servidor responde também usando o mesmo protocolo o conteúdo solicitado.

    O que é Request
    A Request ou requisição traduzindo diretamente para português, é o pedido que um cliente realiza a nosso servidor. Esse pedido contém uma série de dados que são usados para descrever exatamente o que o cliente precisa. Vamos pensar que um cliente precisa cadastrar um novo produto, ele deve passar todos os dados necessários para o cadastro acontecer de maneira correta, inclusive os dados que foram digitados pelo usuário em um formulário, no caso de uma aplicação web. No navegador toda vez que trocamos de página ou apertamos enter na barra de endereço uma nova request é feita. Independente se estamos apenas pedindo a exibição de uma página, cadastrando um novo recurso, atualizando ou excluindo.

    O que é GET e POST?
    Tanto GET como POST na verdade são métodos HTTP. Eles indicam para o servidor qual a ação que o cliente deseja realizar. Quando realizamos uma requisição obrigatoriamente precisamos informar um método.

    GET – é usado quando o cliente deseja obter recursos do servidor
    POST – é usado quando o cliente deseja enviar dados para processamento ao servidor, como os dados de um formulário, por exemplo.
    Existem outros métodos HTTP. Os dois métodos citados acima são os mais usados, principalmente em aplicações web. Quando o usuário digita um endereço e aperta enter na barra de endereço do navegador, ele realiza uma requisição do tipo GET. Já quando preenchemos um formulário e clicamos em enviar geralmente o método usado é o POST.

    O que é Response
    Vimos que o cliente envia uma Request (requisição) ao servidor. Essa requisição possui todas as informações acerca do que o cliente espera receber de volta. O servidor web ao receber essas informações precisa enviar uma resposta ao cliente, nesse ponto entra a Response. A Response (resposta) nada mais é do que a resposta que o servidor envia ao cliente. Essa resposta pode conter os dados que realmente o cliente esperava receber ou uma resposta informando que alguma coisa deu errado.

    O que é 200, 404, 301 e outros números?
    Esses números são os chamados códigos HTTP. Quando o cliente faz uma requisição ele espera uma resposta. O servidor pode realmente responder o que o cliente esperava ou devolver outra informação, justamente nesse ponto entram os códigos HTTP. O servidor utiliza um código desse na resposta para indicar o que aconteceu.

    Os códigos estão entre 100 e 500, sendo que cada centena indica uma categoria:

    1xx – Informativos
    2xx – Indicativos de sucesso
    3xx – Redirecionamentos
    4xx – Erros do cliente na hora de fazer a solicitação
    5xx – Erros no lado do servidor
    Dentro de cada centena temos os códigos específicos, por exemplo:

    200 - Tudo ocorreu corretamente
    301 – Indica redirecionamento permanente
    401 – Não autorizado
    404 – O recurso solicitado não foi encontrado no servidor
    Existem vários sites que especificam todos os códigos HTTP. Esse usa cachorrinhos como exemplo , mas se você gosta mais dos gatinhos também existe.

    Resumo
    O HTTP é o protocolo que define as regras para a comunicação entre o cliente o servidor. No fluxo básico o cliente realiza uma requisição para o servidor, nessa requisição é enviada além de várias outras informações um método que indica a ação que ele deseja. O servidor devolve uma resposta, nessa resposta, além de outras informações, existe um código que indica ao cliente o que aconteceu. Caso você queira se aprofundar no assunto também abordamos no blog sobre o protocolo HTTP/2, que é a evolução do HTTP.

## Como criar projetos ASP.NET Core

    dotnet new mvc -o <nameApp> --no-https
        * a flag --no-https é utilizada quando queremos desenvolver uma aplicação sem utilizar o protocolo https. 
        * basta acessar o endereço local criado

    dotnet run
        * Compila o projeto e executa a aplicação. 

## O que é o MVC
    Em meio ao desenvolvimento de software, você pode ter visto em algum momento a sigla “MVC”. Confira neste artigo o que vem a ser o MVC – ou Model-View-Controller.

    ## Afinal, o que é MVC?
    O MVC é um padrão de arquitetura de software. O MVC sugere uma maneira para você pensar na divisão de responsabilidades, principalmente dentro de um software web.

    O princípio básico do MVC é a divisão da aplicação em três camadas: a camada de interação do usuário (view), a camada de manipulação dos dados (model) e a camada de controle (controller).

    Com o MVC, é possível separar o código relativo à interface do usuário das regras de negócio, o que sem dúvida traz muitas vantagens que veremos mais à frente.

    ## Quais os papéis de cada camada?
    Quando falamos sobre o MVC, cada uma das camadas apresenta geralmente as seguintes responsabilidades:

    ● Model A responsabilidade dos models é representar o negócio. Também é responsável pelo acesso e manipulação dos dados na sua aplicação.

    ● View A view é responsável pela interface que será apresentada, mostrando as informações do model para o usuário.

    ● Controller É a camada de controle, responsável por ligar o model e a view, fazendo com que os models possam ser repassados para as views e vice-versa.

    ## Vamos a um exemplo…
    Vamos utilizar o exemplo de uma página web, onde o usuário pode realizar o cadastro de clientes. Neste caso, provavelmente você teria uma classe chamada cliente.php que contém as informações do cliente que você deseja guardar (como nome, endereço, cidade, etc.). Essa classe seria o seu model.

    Aqui, ainda poderíamos acoplar aspectos de manipulação de bancos de dados, concentrando nesta estrutura os métodos para inserir, alterar, excluir e listar os clientes a partir de uma tabela em um banco de dados.

    A página HTML seria nossa view, que mostraria, por exemplo, a lista de usuários cadastrados ou mesmo o próprio formulário para cadastro de novos usuários.

    O controller faz o meio de campo entre o model e a view. Ele é necessário porque as estruturas presentes com view não deveriam acessar diretamente os models, já que isso poderia criar um acoplamento entre as estruturas de apresentação e definição de negócio: é necessária uma estrutura intermediária para fazer essa ligação.

    E aqui entra o controller, que age como uma ponte entre os dois. Você pode ter uma classe dentro do seu projeto PHP para fazer o papel de um controller, realizando a ligação entre models e views.

    O MVC e sua importância
    Não dá para falar do MVC sem citar a importância que ele traz em meio ao desenvolvimento de software.

    Uma dessas vantagens é que ele nos ajuda a deixar o código mais manutenível, ou seja, mais fácil de fazer manutenção, já que temos as responsabilidades devidamente separadas. Isso também traz uma facilidade na compreensão do código, além da sua reutilização.

    Além disso, você tem um código mais testável, pois ele é mais granular: se você tem uma aplicação onde, por exemplo, na página de listagem de usuários, o nome do usuário está sendo cortado ou não está sendo exibido da maneira correta, é muito mais fácil você fazer um teste que atinja somente as estruturas de views.

    Aqui, podemos ver claramente que você tem um problema de apresentação: os models não são responsáveis por aspectos de apresentação, assim como os controllers também não são… Veja que é até mais fácil de identificar que o problema está na view. Por isso, você consegue corrigir somente a view e testá-la de maneira isolada.

    Um segundo exemplo seria se você tivesse um problema de validação ou uma informação de um campo que o usuário está preenchendo na view e não está chegando no banco de dados: não é a view que envia coisas para o banco de dados, assim como também não é o model que é responsável por esse papel (aliás, o model pode até enviar coisas para o banco de dados, mas essas informações são repassadas por outras estruturas anteriores).

    Então, podemos chegar à conclusão de que o problema é no controller. Sendo assim, você consegue trabalhar somente no controller, sabendo que as alterações provavelmente não irão impactar nas views e nos models. Além disso, você conseguirá realizar testes de uma maneira muito mais rápida e eficiente.

    Considerações finais…
    Por conta dessas facilidades que o MVC oferece, ele passou a ser adotado por diversos frameworks. Além disso, o MVC pode ser utilizado em diversos tipos de projetos, se tornando muito popular no desenvolvimento web, embora você também pode criar uma aplicação MVC para outras plataformas, como desktop ou mobile.

    Caso você tenha dúvida se pode utilizar o MVC em qualquer linguagem de programação, a resposta é sim: isso porque o MVC não é um conceito de linguagem de programação, e sim um conceito de arquitetura. Você não tem uma linguagem que suporte isso ou não: basta você seguir os princípios da arquitetura, que estão mais focados em separar as responsabilidades das coisas do que na tecnologia em si.

    É importante que todo desenvolvedor tenha conhecimento sobre o MVC, pois ele é amplamente utilizado e difundido pelo mercado. Também é interessante conhecer outros patterns baseados no MVC e que são utilizados com frequência no mercado, como o MVVM e o MVP.

## Entendendo a estrutura do Projeto

    <nameProject.csproj>
        Arquivo de configurações do projeto e de funcionalidades, ativas ou não, dentro da aplicação

    Program.cs
        * Ponto de partida da nossa aplicação
        * primeiro arquivo que é executado
        * Contém as configurações iniciais da aplicação, incluindo a criação da aplicação, as configuraçãos de arquivos estáticos, de roteamento, de controllers, migrations, de execução, etc. 

    appsettings.json 
        * Arquivos de configurações internas, que serão utilizadas dentro da aplicação e podem ser substituidos por arquivos de variáveis de ambiente. 

    wwwroot
        * responsável por armazenar todos os arquivos estáticos da aplicação. 

    Views
        * Responsável por armazenar as Views, os templates, da aplicação, ou seja os arquivos cshtml (arquivos do template engine utilizado no APS.NET Core, o Razor)

    Properties
        * Responsável pelos perfis de execução da aplicação.

    obj
        * Responsável pelos arquivos importados para a aplicação. 
        * Não mexer

    Model
        * Responsável pelos arquivos de modelo, ou seja, de comunicação com o banco de dados

    Controllers
        * responsável pela camada de controllers, ou seja, arquivos que manipulam a parte de requisição e resposta da aplicação. Em outras palavras, é o back-end da aplicação.         

