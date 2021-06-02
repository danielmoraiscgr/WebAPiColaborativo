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

## Mudge

| RNO1  | RNO2 | RNO3 | RNO4  | RNO5 | RNO6 | RNO7  | RNO8 | TOTAL | Porcentagem  |
| -----|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|
|    | RNO2 | RNO3 | RNO4  | RNO5 | RNO6 | RNO7  | RNO8 |
|RNO1| RNO1-2 |	RNO1-2 |	RNO1-2 | RNO1-2 |	RNO1-2 |	RNO1-2 |	RNO1-2 |	14	| 27% |
|     | RNO2 |	RNO2-2 |	RNO2-1	| RNO2-1 |	RNO2-1 |	RNO2-1 |	RNO2-1 |	6 |	12% |
|     |     | RNO3 |	RNO3-2 |	RNO3-2 |	RNO3-1 |	RNO3-1 |	RNO3-2 |	8 |	16% |
|     |     |     | RNO4 |	RNO4-2 |	RNO4-1 |	RNO4-1 |	RNO4-2 |	6 |	12% |
|     |     |     |     | RNO5 |	RNO5-2 |	RNO5-2 |	RNO5-1 |	5 |	10% |
|     |     |     |     |     | RNO6 |	RNO6-3 |	RNO6-3 |	6 |	12% |
|     |     |     |     |     |     | RNO7 |	RNO7-3 |	3 |	6% |
|     |     |     |     |     |     |     | RNO8 |	3 |	6% |
|     |     |     |     |     |     |     |     | 51  |	100% |













