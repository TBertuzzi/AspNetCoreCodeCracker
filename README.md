# AspNetCoreCodeCracker

 Exemplo de CodeCracker com .net 6

Code Cracker é pacote nuget que busca melhorar a produtividade do desenvolvedor e  baseada no mecanismo de compilação da plataforma .NET ,Roslyn.
Criado po uma Equipe Brasileira : [Criadores](https://code-cracker.github.io/contact.html), Code cracker nos ajuda a indentificar possiveis falhas em nosso código.

Este exemplo em asp.net core 6 é bem simples e foi feito para demonstrar como o o CodeCracker funciona.

Caso não queira instalar um Pacote nuget em sua aplicação é possivel utilizar a ferramenta [sonarlint](https://code-cracker.github.io/contact.html) . Porem ao utilizar o CodeCracker é possivel utilizar uma [extensão](https://github.com/code-cracker/code-cracker/releases) para o [SonarQube](https://www.sonarqube.org/) melhorando ainda mais a verificação da qualidade de código do mesmo.

Para instalar o CodeCracker, basta adicionar o pacote nuget em todos os seus projetos : 

<img src="https://github.com/TBertuzzi/AspNetCoreCodeCracker/blob/main/Resources/nuget.jpg?raw=true" width="1000" height="600" alt="Blog" />

Em seguida durante o Build a Magica Acontece , veja que criei exemplos absurdos (Que eu espero que você não utilize em seu dia a dia :P) para demonstrar a utilização :

<img src="https://github.com/TBertuzzi/AspNetCoreCodeCracker/blob/main/Resources/codeCracker.jpg?raw=true" width="600" height="500" alt="Blog" />

E :

<img src="https://github.com/TBertuzzi/AspNetCoreCodeCracker/blob/main/Resources/codeCracker2.jpg?raw=true" width="800" height="500" alt="Blog" />

Caso queira ver a utilização do CodeCracker em uma esteira de Devops deixo aqui um artigo do Meu amigo e MVP [Luis Carlos Faria](https://gago.io/?utm_source=facebook&utm_medium=gagoio) o Gago : [Underwater – Construindo Libraries .NET Standard Profissionais](https://gago.io/blog/underwater-construindo-libraries-net-standard-profissionais/?utm_medium=gagoio&utm_source=facebook&fbclid=IwAR3nDbengFC2KgxFTtb5VPHpnXhfrDdiKL7Sv40lZ-E-84XSNvXev-AuDsM)
