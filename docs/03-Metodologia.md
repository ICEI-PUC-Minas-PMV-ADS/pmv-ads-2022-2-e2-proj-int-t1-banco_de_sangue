
# Metodologia

O desenvolvimento deste projeto, originou-se da observação da escassez de sangue no Brasil trabalhando por sua vez a limitação que o brasileiro encontra no acesso aos canais tradicionais de informação sobre o tema.
 
Serão feitas reuniões entre a equipe de forma on-line na ferramenta Teams, através de conversas pelo aplicativo WhatsApp, durante este trabalho, será usada a metodologia Scrum de desenvolvimento ágil, dividindo esforço de entrega em sprints de 1 semana. 

## Relação de ambientes de trabalho

Os artefatos do projeto serão desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue.

|Ambiente | Plataforma  | Endereço |
|---------|-------------|-------------|
|Repositório de código fonte| GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-banco_de_sangue |
|Ferramenta para controle de versão| Git | https://git-scm.com/ |
|Documentos do projeto| GitHub |  https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t1-banco_de_sangue/blob/main/docs/01-Documenta%C3%A7%C3%A3o%20de%20Contexto.md |
|Projeto de interface e Wireframes| Canva | https://sgapucminasbr-my.sharepoint.com/:i:/g/personal/1408097_sga_pucminas_br/Ec0stXKnxoJOhVsNzRq4LYoBAhGv1euXFgMA5CrCZq-8Bw?e=tpEkKE |
|Gerenciamento do projeto| Trello | https://trello.com/b/KRFCKLn0/grupo-1-turma-1-eixo-2-ads-2022 |
|Editor de código| Visual Studio Comunity 2019 | https://portal.azure.com/?Microsoft_Azure_Education_correlationId=482c7b3fd428421ebc975fb5a28dcb48#view/Microsoft_Azure_Education/EducationMenuBlade/~/software |
|Banco de dados| SQL Server Management Studio 2018 | https://docs.docker.com/desktop/install/windows-install/ |

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código: Visual Studio Comunity 2019
- Ferramentas de comunicação: WhatsApp e Teams.
- Ferramentas de desenho de tela: [Canva] (https://www.canva.com/).

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão.
As ferramentas de comunicação utilizadas possuem integração semelhante e por isso foram selecionadas.
Por fim, para criar diagramas utilizamos essa ferramenta por melhor captar as necessidades da nossa solução e pela familiaridade da equipe com a ferramenta.

## Controle de Versão (gestão de código fonte)

 Para gestão do código fonte da aplicação interativa desenvolvida pela equipe, o grupo utiliza o sistema de controle de versão [Git](https://git-scm.com/). Esta escolha se deu pois o Git possui uma arquitetura descentralizada que permite um bom de controle de versão, o Git registra as mudanças que ocorrem no código-fonte de um projeto. Logo, permite que os arquivos sejam alterados de forma simultânea, por inúmeras pessoas, sem a preocupação que essas alterações sejam sobrescritas umas pelas outras.
 
 Devido a essa funcionalidade, caso haja algum problema em uma alteração do código-fonte, é possível restaurar à versão anterior de forma fácil e rápida. Sendo assim, em cada repositório, incluindo o da máquina do contribuidor, vai existir uma cópia completa e funcional, permitindo a utilização das operações mesmo offline.
 
 Considerando que os projetos costumam estar em constante evolução, é comum ocorrer alterações que possam causar problemas no funcionamento deles. Nesse caso, o Git permite que tais alterações sejam revertidas de maneira simples e rápida, voltando a versão antiga do projeto.
 
Para este versionamento e controle de código fonte, estabelecemos o seguinte fluxo:

1. Clone do projeto (cada membro do grupo criou o clone do projeto em sua máquina). 
2.	Criação da Branch (ramificação independente que permite alterar os arquivos sem interferir no original).
3.	Commits (descrição objetiva de cada commit conforme funcionalidade)
4.	Pull (Utilizado para buscar e trazer mudanças do repositório remoto para o repositório local, ou seja, unir os conteúdos dos arquivos alterados. Em alguns casos, pode ser necessária uma intervenção humana para realizar essa)
5.	Push (Após finalizada a funcionalidade enviamos a nossa branch com as alterações para o repositório remoto, permitindo que os membros do grupo possam ver e alterar se necessário).
6.	Merge (Ato de mesclar as modificações das branchs com os arquivos originais do projeto da Branch principal, deixando disponível para os demais contribuidores).

 Sendo que o [Github](https://github.com) foi utilizado para hospedagem do repositório.
 
 
 ![image](https://user-images.githubusercontent.com/112259936/193463783-a6266a14-cce0-4e43-af2b-7657d93e4ed5.png)


## Gerenciamento de Projeto

### Divisão de Papéis

A equipe fará uso da metodologia ágil Scrum como base para definição de todo o processo de desenvolvimento.

Portanto, a equipe está organizada da seguinte maneira:

● Scrum Master: Paola Marsura Verreschi de Oliveira

● Product Owner: Barbara Benedetti Cavalcante

● Equipe de Desenvolvimento:
- Jair Junio Da Silva
- Ríder Rocha Cantuária
- Paula Lavínia Alves Perret

● Equipe de Design:
- Andre Felipe Gomes Pinto
- Luiz Eduardo Tavares Costa

### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando Trello estruturado com as seguintes listas:

•	Documentação e links: esta lista armazena os documentos de direcionamento do projeto, bem como o cronograma de entrega a ser seguido; nela ficam também os links oficiais utilizados pela equipe e os materiais de apoio. Também é nela que ficam armazenado os arquivos que competem ao modelo de padronização do projeto. 

•	Gerenciamento do projeto / (backlog): esta lista elenca as etapas necessárias para execução do projeto; cada card de etapa contém os requisitos de entrega, também serve para armazenamento de arquivos referente a cada etapa, ou seja, esta lista recebe as tarefas a serem trabalhadas, representando o Product Backlog.

•	Desenvolvimento: esta lista é dinâmica e seu objetivo é apresentar a etapa em desenvolvimento conforme o cronograma (sprint atual), seus cards apresentam as tarefas a serem trabalhadas, assim esta lista representa o Sprint Backlog.

•	Teste: Checagem de Qualidade, quando as tarefas são concluídas, elas são movidas para esta lista, os cartões chegam aqui após a revisão do código; as tarefas desta lista estão em fase de teste, é nesta fase que serão realizadas as correções apontadas pelo controle de qualidade. A revisão do design também acontece nesta fase.

•	Ação necessária: Quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa.

•	Conclusão: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontas para serem entregues ao usuário. Não há mais edições ou revisões necessárias, elas estão agendadas e prontas para a ação.


O quadro kanban do grupo no Trello está disponível através do link [Quadro Trello](https://trello.com/b/KRFCKLn0/grupo-1-turma-1-eixo-2-ads-2022) e é apresentado, no estado atual, na figura  abaixo. 

![image](https://user-images.githubusercontent.com/103156976/193410768-e3a39d30-62e3-49dc-972b-e024e8c77d02.png)



