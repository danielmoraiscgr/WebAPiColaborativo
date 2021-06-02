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

|        | [RNO2] |	[RNO3] | [RNO4] |	[RN05] | [RNO6] |	[RNO7] | [RN08] | [Total] |	[%] |
| ------ |:------:|:------:|:------:|:------:|:------:|:------:|:------:|:-------:|:---:|
| <b>RNO1</b>] | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | RNO1-2 | 14 | 27% |
|	       | [RNO2] | RNO2-2 | RNO2-1 | RNO2-1 | RNO2-1 | RNO2-1 | RNO2-1 | 6 | 12% |
|		     |        | [RNO3] | RNO3-2 | RNO3-2 | RNO3-1 | RNO3-1 | RNO3-2 | 8 | 16% |
|        |        |        | [RNO4] | RNO4-2 | RNO4-1 | RNO4-1 | RNO4-2 | 6 | 12% |
|				 |        |        |        | [RNO5] | RNO5-2 | RNO5-2 | RNO5-1 | 5 | 10% |
| 	  	 |			  |        |        |        | [RNO6] | RNO6-3 | RNO6-3 | 6 | 12% |
| 	  	 |			  |        |        |        |        | [RNO7] | RNO7-3 | 3 | 6% |
| 	  	 |			  |        |        |        |        |        | [RNO8] | 3 | 6% |
| 	  	 |			  |        |        |        |        |        |        | 51 | 100% |
                      ____Peso 1 – pouco mais importante
                      ____Peso 2 – moderadamente mais importante
                      ____Peso 3 – muito mais importante
                      
                      
## A Matriz de dependência de requisitos												
												
| [Requisistos de negócio]                              | [RF01] | [RF02] | [RF03] | [RF04] | [RF05] | [RF06] | [RF07] | [RF08] |
| --------------------------------------------------- |:----:|:----:|:----:|:----:|:----:|:----:|:----:|:----:|												
| [RN01] |	Conhecer as Disciplinas                     |   X  |      |      |      |      |      |      |      |							
| [RN02] |	Conhecer as Graduação dos Professores       |   X  |   X  |      |      |      |      |      |      |						
| [RN03] |	Conhecer os Professores                     |   X  |      |   X  |      |      |      |      |      |					
| [RN04] |	Conhecer os Alunos                          |   X  |      |      |      |      |      |      |      |							
| [RN05] |	Ligar os alunos as disciplinas              |   X  |      |      |      |      |      |      |      |							
| [RN06] |	Lancar as notas dos alunos                  |   X  |      |      |      |      |      |      |      |							
| [RN07] |	Calcular aprovação dos alunos               |   X  |      |      |      |      |      |      |      |							
| [RN08] |	Calcular aprovação por disciplina           |   X  |      |      |      |      |      |      |      |						
|                                                                                                                   |
| [Requisistos Funcionais]	                            | [RF01] | [RF02] | [RF03] | [RF04] | [RF05] | [RF06] | [RF07] | [RF08] |
| [RF01] |	Cadastramento de Disciplinas				        |   X  |      |      |   X  |   X  |      |      |   X  |
| [RF02] |	Cadastramento de Graduação							    |      |   X  |      |   X  |      |      |      |      |
| [RF03] |	Cadastramento de Professores						    |   X  |   X  |   X  |   X  |      |      |      |      |
| [RF04] |	Cadastramento de Disciplinas por Professor	|   X  |      |   X  |   X  |   X  |      |      |      |	
| [RF05] |	Cadastramento de Alunos								      |   X  |      |      |      |      |   X  |      |   X  |
| [RF06] |	Cadastrar as Notas por Disciplina				    |   X  |      |      |      |   X  |   X  |   X  |   X  |
| [RF07] |	Relatório de Alunos Aprovados				        |   X  |      |      |      |   X  |   X  |   X  |   X  |
| [RN08] |	Relatório de nível de aprovação disciplina	|   X  |      |      |      |      |      |      |   X  |			







