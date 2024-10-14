import { useNavigate } from "react-router-dom";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Container, TextContent, Title, TitleHightLight } from "./styles";
import bannerImage from "../../assets/TempleteHome.png";

const Home = () => {
  const navigate = useNavigate();

  const handleClickSignIn = () => {
    navigate("/login");
  };

  return (
    <>
      <Header />
      <Container>
        <div>
          <Title>
            <TitleHightLight>
              Implemente <br />
            </TitleHightLight>
            o seu futuro global agora!
          </Title>
          <TextContent>
            Domine as tecnologias utilizadas pelas empresas mais inovadoras do
            mundo e encare seu novo desafio profissional, evoluindo em
            comunidade com os melhores experts.
          </TextContent>
          <Button
            title="Começar Agora"
            variant="secundary"
            onClick={handleClickSignIn}
          />
        </div>
        <div>
          <img src={bannerImage} alt="Img principal" />
        </div>
      </Container>
    </>
  );
};

export { Home };
