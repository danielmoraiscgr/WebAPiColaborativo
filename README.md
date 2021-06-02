# WebAPiColaborativo (Sistema de Notas)

## Requisitos de Negócio

| Código  | Requisito | Detalhes |
| ------------- |:-------------:|:---------------:|
| RN01     | Conhecer as Disciplinas     | Para conseguir controlar o nível de aprovação, precisa-se do cadastro de disciplinas
| RN02      | Conhecer as Graduações dos Professores     | Cadastras as graduações. Para cadastras os professores precisa-se do cadastro de graduação
| RN03      | Conhecer os Professores  |Para cadastrar os professores, precisa que as graduações estejam cadastradas.  
| RN04      | Conhecer os Alunos  | Cadastrar os alunos da instituição de ensino.
| RN05     | Ligar os alunos as disciplinas  | Cada aluno precisa ter as disciplinas cadastradas do semestre letivo.
| RN06     | Lançar as notas dos alunos.  | Para conseguir o resultado de nível de aprovação por disciplina, as notas dos alunos do semestre devem estar lançados.
| RN07     | Calcular aprovação dos alunos  | Processar o calculo de aprovação do aluno. Informando que os alunos com média <=5 (REP) >5 e <7 (REC) e >=7 (AP)
| RN08     | Calcular aprovação por disciplina | Calcular o percentual de alunos aprovados (AP) por disicplina. E apresentar em relatório e gráficos.

## Requisitos Funcionais

| Código  | Requisito | Detalhes |
| ------------- |:-------------:|:---------------:|
| RF01     | Cadastramento de Disciplinas    | Inserir, Alterar, Consultar, Deletar e Relatório das Disciplinas
| RF02     | Cadastramento de Graduação    | Inserir, Alterar, Consultar, Deletar e Relatório das Graduação
| RF03     | Cadastramento de Professores   | Inserir, Alterar, Consultar, Deletar e Relatório dos Professores
| RF04     | Cadastramento de Disciplinas por Professor    | Inserir, Alterar, Consultar, Deletar e Relatório das Disciplinas por Professor
| RF05    | Cadastramento de Alunos   | Inserir, Alterar, Consultar, Deletar e Relatório de Alunos
| RF06     | Lançamento de Notas por Disciplina   | Inserir, Alterar, Consultar, Deletar e Relatório de Notas por Disciplina. 
| RF07     | Relatório de nível de aprovação por disciplina    | Filtrar o relatório por ano letivo e disciplina. Caso deixe sem informação, vai trazer tudo

## Tabela de Mudge

|        | <b>RNO2</b> | <b>RNO3</b>] | <b>RNO4</b> | <b>RN05</b>] | <b>RNO6</b> | <b>RNO7</b> | <b>RN08</b> | <b>Total</b> | <b>%</b> |
| ------ |:------:|:------:|:------:|:------:|:------:|:------:|:------:|:-------:|:---:|
| <b>RNO1</b>] | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | 14 | 27% |
|	       | <b>RNO2</b> | RNO2-2 | RNO2-1 | RNO2-1 | RNO2-1 | RNO2-1 | RNO2-1 | 6 | 12% |
|		     |        | <b>RNO3</b>] | RNO3-2 | RNO3-2 | RNO3-1 | RNO3-1 | RNO3-2 | 8 | 16% |
|        |        |        | <b>RNO4</b>] | RNO4-2 | RNO4-1 | RNO4-1 | RNO4-2 | 6 | 12% |
|				 |        |        |        | <b>RNO5</b> | RNO5-2 | RNO5-2 | RNO5-1 | 5 | 10% |
| 	  	 |			  |        |        |        | <b>RNO6</b> | RNO6-3 | RNO6-3 | 6 | 12% |
| 	  	 |			  |        |        |        |        | <b>RNO7</b> | RNO7-3 | 3 | 6% |
| 	  	 |			  |        |        |        |        |        | <b>RNO8</b> | 3 | 6% |
| 	  	 |			  |        |        |        |        |        |        | 51 | 100% |
                      ____Peso 1 – pouco mais importante
                      ____Peso 2 – moderadamente mais importante
                      ____Peso 3 – muito mais importante
                      
                      
## A Matriz de dependência de requisitos												
												
| <b>Requisistos de negócio</b>       |                      | <b>RF01</b> | <b>RF02</b> | <b>RF03</b> | <b>RF04</b> | <b>RF05</b> | <b>RF06</b> | <b>RF07</b> | <b>RF08</b> |
| ---------------------------------------------------:|:----:|:----:|:----:|:----:|:----:|:----:|:----:|:----:|:----:|												
| <b>RN01</b> |	Conhecer as Disciplinas               |   X  |     |      |      |      |      |      |      |      |						
| <b>RN02</b> |	Conhecer as Graduação dos Professores |   X  |  X  |      |      |      |      |      |      |      |						
| <b>RN03</b> |	Conhecer os Professores               |   X  |     |   X  |     |      |      |      |      |      |					
| <b>RN04</b> |	Conhecer os Alunos                    |   X  |     |      |      |      |      |      |      |      |						
| <b>RN05</b> |	Ligar os alunos as disciplinas        |   X  |     |      |      |      |      |      |      |      |						
| <b>RN06</b> |	Lancar as notas dos alunos            |   X  |     |      |      |      |      |      |      |      |						
| <b>RN07</b> |	Calcular aprovação dos alunos         |   X  |     |      |      |      |      |      |      |      |						
| <b>RN08</b> |	Calcular aprovação por disciplina     |   X  |     |      |      |      |      |      |      |      |						
|                                                                                                                   |
| <b>Requisistos Funcionais</b>	                            | <b>RF01</b> | <b>RF02</b> | <b>RF03</b> | <b>RF04</b> | <b>RF05</b> | <b>RF06</b> | <b>RF07</b> | <b>RF08</b> |
| <b>RF01</b> |	Cadastramento de Disciplinas	                |      |   X  |      |      |   X  |   X  |      |      |   X  |
| <b>RF02</b> | Cadastramento de Graduação	                |      |      |   X  |      |   X  |      |      |      |      |
| <b>RF03</b> |	Cadastramento de Professores			|      |   X  |   X  |   X  |   X  |      |      |      |      |
| <b>RF04</b> |	Cadastramento de Disciplinas por Professor	|      |   X  |      |   X  |   X  |   X  |      |      |      |	
| <b>RF05</b> |	Cadastramento de Alunos				|      |   X  |      |      |      |      |   X  |      |   X  |
| <b>RF06</b> |	Cadastrar as Notas por Disciplina		|      |   X  |      |      |      |   X  |   X  |   X  |   X  |
| <b>RF07</b> |	Relatório de Alunos Aprovados			|      |   X  |      |      |      |   X  |   X  |   X  |   X  |
| <b>RF08</b> |	Relatório de nível de aprovação disciplina	|      |   X  |      |      |      |      |      |      |   X  |			







