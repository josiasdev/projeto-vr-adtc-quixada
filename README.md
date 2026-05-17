# ADTC Quixadá VR - Experiência no Metaverso

**Aluno:** Francisco Josias da Silva Batista
**Instituição/Curso:** Capacitação em Metaverso (Fase 1)

## Apresentando o Seu Projeto
Este projeto consiste na recriação em Realidade Virtual (VR) do salão principal da Igreja Assembleia de Deus Templo Central (ADTC), localizada no município de Quixadá - CE. O ambiente foi modelado utilizando as ferramentas primitivas da Unity e assets low poly, focando em replicar a estética do local (assentos em madeira, corredor central, altar elevado e iluminação acolhedora). O projeto possui navegação funcional pelo PC e está configurado para o Meta Quest via Meta XR SDK.

## Contexto e Objetivos
O ambiente se insere no contexto de Metaverso focado em **comunicação, congregação e acessibilidade**. O objetivo é demonstrar como espaços físicos destinados a reuniões comunitárias ou religiosas podem ser virtualizados. Isso permite que pessoas com mobilidade reduzida, ou que residem em outras regiões, possam se reunir de forma imersiva em um ambiente familiar, assistindo a palestras e eventos simultaneamente, superando barreiras geográficas.

## Interação Funcional
Foi implementada uma interação de presença utilizando a API de física da Unity (Triggers) em C#. 
Um sensor de proximidade invisível (`Box Collider` com `Is Trigger` ativado) foi posicionado em frente ao altar. Quando o Avatar do usuário (identificado pela tag `Player`) entra nesta zona, um script C# devidamente comentado altera o material do telão principal, simulando que o painel está sendo "ligado" (mudança de cor/material) para iniciar uma apresentação. Ao se afastar, o telão é desligado automaticamente.

## Processo de Criação e Dificuldades
O desenvolvimento iniciou-se com o bloqueio do cenário (blockout) usando formas primitivas para definir a planta baixa e erguer as paredes. A organização da hierarquia foi uma prioridade para agrupar assentos, estrutura e mobiliário do altar de forma lógica.
**Dificuldades:**
1. A principal dificuldade foi replicar o alinhamento em lote das dezenas de assentos (prefab instantiation) sem perder a simetria do corredor central. Foi solucionado utilizando duplicação matemática via atalhos de teclado e ajustes precisos nos eixos X e Z do componente Transform.
2. Na implementação da interação, houve um desafio técnico onde a colisão não era detectada. Isso foi resolvido aplicando um componente `Rigidbody` com a propriedade `Is Kinematic` ativada no Player, permitindo que a engine física computasse a entrada na zona do Trigger de forma correta e ativasse a mudança de cor do telão.
