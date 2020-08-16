# Material de Avaliação Prática - Programação I

Para esta Atividade Mapa, considere que sua empresa resolveu refazer o sistema de gerenciamento interno e, você foi designado para desenvolver o sistema em Java, usando conceitos de orientação a objetos. A especificação do sistema ainda não está completa, mas, seu chefe quer ver o que já foi desenhado, implementado e, em funcionamento.

Portanto, você deve implementar um sistema na linguagem de programação Java que siga as especificações do diagrama de classes abaixo.

![](https://sistemasead.unicesumar.edu.br/flex/amfphp/services/Portal/ImagemQuestionario2/QUE_102217_316365_1.png)

Para a construção do sistema, você deverá utilizar a IDE de desenvolvimento NetBeans - a mesma que foi utilizado na disciplina.
 
1. Pontos de destaque a serem implementados:
	- Lembre-se de que métodos e classes com o nome em itálico são abstratos e, que no diagrama de classes não constam os métodos acessores.
	- O método "exibeDados" deve listar o nome e, o documento da pessoa, assim como qual é o papel da pessoa na organização (presidente, secretária, vendedor ou cliente).
	- O método "verificarSenha" recebe uma senha como parâmetro e, compara com a senha armazenada para o cliente. Não se preocupe com criptografia, a senha vai estar em texto comum e, vai ser comparada com a que for passada com parâmetro.
	- O método "calculaSalarioAnual" retornará o salário somado dos 12 meses, mais o décimo terceiro. Conta simples, mesmo.
	- O método "salarioMesComComissao" vai retornar o salário do vendedor, somado à comissão dele que for cadastrada. Como a comissão é aplicada ao valor de vendas e, essa parte ainda não consta no diagrama, considere que a comissão cadastrada já é o valor final da comissão em reais.
	- Todas as classes (que precisarem dos construtores) devem ter apenas um construtor vazio (sem parâmetros) e, um construtor com todos os parâmetros para já adicionar os valores na criação.

2. Para garantir que o sistema funciona como esperado, seu chefe pediu para realizar as seguintes ações:
	- Cadastre o presidente da empresa, que é o Asdrubal Leôncio Correa.
	- Cadastre as duas secretárias, a Fátima e, a Ana.
	- Cadastre os vendedores João, Vanessa e, Carlos.
	- Cadastre os clientes Marcos, Joana, Elisa e, Lucas.
	- Defina as comissões dos vendedores
	- Calcule o salário anual do Asdrubal e, da Ana.
	- O usuário Lucas esqueceu a senha dele. Verifique se a senha dele é "123456", "segredo" ou "teste".
	- Mande exibir os dados de todas as pessoas (uma por uma).


Essas ações devem ficar em sua classe principal para que, ao executar, as ações já sejam executadas. 

Os detalhes que você não tiver sobre as pessoas você pode inventar.
