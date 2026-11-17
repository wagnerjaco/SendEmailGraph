# SendEmailGraph | .NET 8 + Microsoft Graph API

Aplicação Console desenvolvida em **C#/.NET 8** para envio automatizado de e-mails utilizando a **Microsoft Graph API**, com autenticação OAuth 2.0 por meio do Microsoft Authentication Library (MSAL).

O projeto demonstra uma integração com os serviços do Microsoft 365 por meio de APIs REST.

## Funcionalidades

- Autenticação de aplicação via Microsoft Entra ID.
- Obtenção de Access Token utilizando o fluxo Client Credentials.
- Envio de e-mails HTML pela Microsoft Graph API.
- Configuração de destinatários e cópias (CC).
- Consumo assíncrono de endpoints REST com HttpClient.
- Tratamento básico de erros de autenticação e envio.

## Stack Tecnológica

**Linguagem:** C# / .NET 8  
**API:** Microsoft Graph REST API  
**Autenticação:** OAuth 2.0, MSAL  
**Identidade:** Microsoft Entra ID  
**Serialização:** Newtonsoft.Json  
**Comunicação:** HttpClient, JSON

## Diferenciais Técnicos

- Integração com serviços Microsoft 365.
- Autenticação sem interação do usuário (Client Credentials).
- Utilização de Bearer Token em requisições HTTP.
- Operações assíncronas com async/await.
- Configuração de credenciais e parâmetros de integração.

**Objetivo:** demonstrar conhecimentos em integração de sistemas corporativos, autenticação OAuth 2.0, consumo de APIs REST e desenvolvimento C#/.NET.
