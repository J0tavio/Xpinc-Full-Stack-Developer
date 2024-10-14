import React from "react";
import { useNavigate } from "react-router-dom";
import {
  Container,
  Row,
  Wrapper,
  BuscarInputContainer,
  Menu,
  MenuRight,
  UserPicture,
  Input,
} from "./styles";
import { Button } from "../Button";
import logo from "../../assets/logo.png";

const Header = ({ autenticado }) => {
  const navigate = useNavigate();

  const handleClickSignIn = () => {
    navigate("/login");
  };

  const handleClickCadastrar = () => {
    navigate("/cadastro");
  };

  return (
    <Wrapper>
      <Container>
        <Row>
          <img src={logo} alt="Imagem Dio" />
          {autenticado ? (
            <>
              <BuscarInputContainer>
                <Input placeholder="Buscar..." />
              </BuscarInputContainer>
              <Menu>Live Code</Menu>
              <Menu>Global</Menu>
            </>
          ) : null}
        </Row>
        <Row>
          {autenticado ? (
            <UserPicture src="https://avatars.githubusercontent.com/u/145298522?s=96&v=4" />
          ) : (
            <>
              <MenuRight href="">Home</MenuRight>
              <Button onClick={handleClickSignIn} title="Entrar"></Button>
              <Button onClick={handleClickCadastrar} title="Cadastrar"></Button>
            </>
          )}
        </Row>
      </Container>
    </Wrapper>
  );
};

export { Header };
