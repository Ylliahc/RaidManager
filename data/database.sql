create table IF NOT EXISTS user (
    user_id uuid DEFAULT uuid_generate_V4() NOT NULL,
    name varchar(20) NOT NULL,
    password varchar(20) NOT NULL,
    last_connection_date datetime
);

create table IF NOT EXISTS functional_role (
    id uuid DEFAULT uuid_generate_V4() NOT NULL,
    name varchar(255) NOT NULL
)

CREATE TABLE IF NOT EXISTS user_role (
    user_id uuid NOT NULL,
    functional_role_id NOT NULL
)

create table IF NOT EXISTS authorized_client (
    id uuid DEFAULT uuid_generate_V4() NOT NULL,
    name varchar(255) NOT NULL,
    display_name varchar(255) NOT NULL,
    secrets varchar(255) NOT NULL
)

create table IF NOT EXISTS authorized_scope (
    id uuid DEFAULT uuid_generate_V4() NOT NULL,
    name varchar(255) NOT NULL
)

create table IF NOT EXISTS authorized_client_scope (

)