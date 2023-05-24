# Exemplo de SQL Injection

## Descrição

Neste exemplo, o programa solicita ao usuário que insira um nome. O código gera uma consulta SQL dinâmica concatenando a entrada do usuário na string de consulta. Isso é uma vulnerabilidade de SQL Injection, pois um usuário mal-intencionado poderia inserir um valor que alteraria a lógica da consulta e comprometeria a segurança do sistema.

Para evitar essa vulnerabilidade, é recomendado o uso de consultas parametrizadas ou a implementação de mecanismos de ORM (Object-Relational Mapping), como o Entity Framework, que lidam automaticamente com a segurança contra SQL Injection.