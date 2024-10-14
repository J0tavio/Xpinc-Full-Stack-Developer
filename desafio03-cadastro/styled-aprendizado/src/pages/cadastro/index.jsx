import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
import { useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import { MdEmail, MdLock, MdPerson } from "react-icons/md";
import * as yup from "yup";
import { Button } from "../../components/Button";
import {
  Container,
  SubtitleCadastro,
  Title,
  TitleCadastro,
  Column,
  FazerLogin,
  JaTenhoConta,
  MensagemAoClicar,
  Wrapper,
  Row1,
  Row2,
} from "./styles";

const schema = yup
  .object({
    nome: yup.string().default("Nome inválido").required("Campo obrigatório"),
    email: yup
      .string()
      .email("Email não é válido")
      .required("Campo obrigatório"),
    password: yup
      .string()
      .min(3, "No mínimo 3 caracteres")
      .required("Campo obrigatório"),
  })
  .required();

const Cadastro = () => {
  const {
    control,
    handleSubmit,
    formState: { errors },
  } = useForm({ resolver: yupResolver(schema), mode: "onChange" });

  return (
    <>
      <Header />
      <Container>
        <Column>
          <Title>
            A plataforma para você aprender com experts, dominar as principais
            tecnologias e entrar mais rápido nas empresas mais desejadas.
          </Title>
        </Column>

        <Column>
          <Wrapper>
            <TitleCadastro>Comece agora grátis</TitleCadastro>
            <SubtitleCadastro>
              Crie sua conta e make the change._
            </SubtitleCadastro>
            <Input
              name="nomeCompleto"
              placeholder="Nome Completo"
              type="name"
              control={control}
              leftIcon={<MdPerson />}
            />
            <Input
              name="email"
              placeholder="E-mail"
              type="email"
              control={control}
              leftIcon={<MdEmail />}
            />
            <Input
              name="password"
              placeholder="Password"
              type="password"
              control={control}
              leftIcon={<MdLock />}
            />
            <Button
              title="Criar minha conta"
              variant="secondary"
              type="submit"
            />
            <Row1>
              <MensagemAoClicar>
                Ao clicar em "criar minha conta grátis", declaro que aceito as
                Políticas de Privacidade e os Termos de Uso da DIO.
              </MensagemAoClicar>
            </Row1>
            <Row2>
              <JaTenhoConta>Já tenho conta.</JaTenhoConta>
              <FazerLogin>Fazer login</FazerLogin>
            </Row2>
          </Wrapper>
        </Column>
      </Container>
    </>
  );
};

export { Cadastro };
