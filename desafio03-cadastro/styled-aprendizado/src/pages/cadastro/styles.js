import styled from "styled-components";

export const Container = styled.main`
  width: 100%;
  max-width: 80%;
  margin: 0 auto;
  margin-top: 120px;

  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
`;

export const Title = styled.h2`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 32px;
  width: 388px;
  margin-bottom: 20px;
  line-height: 44px;
  color: #ffffff;
`;

export const TitleCadastro = styled.p`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 32px;
  width: 368px;
  height: 44px;
  margin-bottom: 20px;
  line-height: 44px;
`;

export const SubtitleCadastro = styled.p`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 400;
  font-size: 18px;
  margin-bottom: 35px;
  width: 296px;
  height: 25px;
  line-height: 25px;
`;

export const Column = styled.div`
  flex: 1;
`;

export const Wrapper = styled.div`
  max-width: 372px;
`;

export const Row1 = styled.div`
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  margin-top: 20px;
`;
export const Row2 = styled.div`
  display: flex;
  flex-direction: row;
  align-items: center;
  margin-top: 20px;
`;

export const MensagemAoClicar = styled.p`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 400;
  font-size: 18px;
  width: 372;
  height: 75px;
  line-height: 25px;
`;

export const JaTenhoConta = styled.p`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 14px;
  line-height: 19px;
  margin-right: 5px;
`;

export const FazerLogin = styled.p`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 14px;
  line-height: 19px;
  color: #23dd7a;
`;
