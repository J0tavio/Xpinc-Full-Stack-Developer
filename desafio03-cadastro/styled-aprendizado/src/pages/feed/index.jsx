// import { Button } from "../../components/Button";
import { UserInfo } from "../../components/UserInfo";
import { Card } from "../../components/Card";
import { Header } from "../../components/Header";
import { Container, Column, Title, TitleHightLight } from "./styles";
// import bannerImage from "../../assets/TempleteHome.png";

const Feed = () => {
  return (
    <>
      <Header autenticado={true} />
      <Container>
        <Column flex={3}>
          <Title>Feed</Title>
          <Card />
          <Card />
          <Card />
          <Card />
        </Column>

        <Column flex={1}>
          <TitleHightLight># RANKING 5 TOP DA SEMANA</TitleHightLight>
          <UserInfo
            percentual={90}
            nome="João Otávio"
            image="https://avatars.githubusercontent.com/u/145298522?s=96&v=4"
          />
          <UserInfo
            percentual={75}
            nome="João Otávio"
            image="https://avatars.githubusercontent.com/u/145298522?s=96&v=4"
          />
          <UserInfo
            percentual={45}
            nome="João Otávio"
            image="https://avatars.githubusercontent.com/u/145298522?s=96&v=4"
          />
          <UserInfo
            percentual={39}
            nome="João Otávio"
            image="https://avatars.githubusercontent.com/u/145298522?s=96&v=4"
          />
          <UserInfo
            percentual={27}
            nome="João Otávio"
            image="https://avatars.githubusercontent.com/u/145298522?s=96&v=4"
          />
        </Column>
      </Container>
    </>
  );
};

export { Feed };
