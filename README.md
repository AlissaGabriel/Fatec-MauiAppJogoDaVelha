# Jogo da Velha - .NET MAUI

## Sobre o Projeto

Este aplicativo foi desenvolvido utilizando .NET MAUI com o objetivo de recriar o jogo da velha de forma interativa.

O jogo permite que dois jogadores participem alternando entre os símbolos **X** e **O**.

Ao longo da partida, o aplicativo:

1. Registra as jogadas dos jogadores
2. Alterna automaticamente os turnos
3. Verifica condições de vitória
4. Identifica empate
5. Permite reiniciar a partida

---

## Conteúdos Aprendidos

Durante o desenvolvimento deste projeto foram aprendidos os seguintes conceitos:

### Interface gráfica com XAML

Uso de componentes como:

* Grid
* Button
* Label
* Styles
* LinearGradientBrush

### Programação em C#

* Manipulação de eventos (`Clicked`)
* Estruturas condicionais (`if`, `else`)
* Arrays
* Laços de repetição (`foreach`)
* Controle de estados dos botões (`IsEnabled`)
* Alternância de jogadores utilizando operador ternário

### Desenvolvimento Mobile com .NET MAUI

* Associação entre XAML e código C#
* Estilização de componentes
* Atualização dinâmica da interface

---

## Funcionamento do Aplicativo

* O jogador X inicia a partida
* Cada jogador escolhe uma posição no tabuleiro
* O sistema verifica automaticamente se houve vitória
* Caso todas as posições sejam preenchidas sem vencedor, ocorre empate
* Após o término da partida, é possível iniciar um novo jogo

---

## Regras do Jogo

O vencedor é o jogador que conseguir formar uma linha com três símbolos iguais:

* Horizontalmente
* Verticalmente
* Diagonalmente

---

## Recursos Utilizados

* Sistema de alternância entre jogadores
* Verificação automática de vitória
* Sistema de empate
* Botão de reinício da partida
* Interface estilizada com gradiente

---

## Como Executar o Projeto

1. Clone o repositório
2. Abra o projeto no Visual Studio 2026
3. Execute o projeto em um emulador Android ou Windows

---

## Estrutura do Projeto

* `MainPage.xaml` → Interface gráfica do jogo
* `MainPage.xaml.cs` → Lógica da partida e verificação de vitória

---

Projeto desenvolvido para a disciplina de Programação para Dispositivos Móveis II com .NET MAUI.
