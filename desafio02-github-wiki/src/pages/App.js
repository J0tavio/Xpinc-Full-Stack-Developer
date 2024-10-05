import { useState } from "react";
import github from "../assets/github.png";
import Input from "../components/input";
import ItemRepo from "../components/ItemRepo";
import { Container } from "./styles";
import Button from "../components/button";
import { api } from "../services/api";

function App() {
  const [currentRepo, setCurrentRepo] = useState("");
  const [repos, setRepos] = useState([]);

  const handleSearchRepo = async () => {
    const { data } = await api.get(`repos/${currentRepo}`);

    if (data.id) {
      const isExist = repos.find((repo) => repo.id === data.id);
      if (!isExist) {
        setRepos((prev) => [...prev, data]);
        setCurrentRepo("");
      }
    }
    // alert("Repositório não encontrado");
  };

  const handleRemoveRepo = (id) => {
    const updatedRepos = repos.filter((repo) => repo.id !== id);
    setRepos(updatedRepos);
  };

  return (
    <Container>
      <img src={github} width={72} height={72} alt="github logo"></img>
      <Input
        value={currentRepo}
        onChange={(e) => setCurrentRepo(e.target.value)}
      />
      <Button onclick={handleSearchRepo} />
      {repos.map((repo) => (
        <ItemRepo handleRemoveRepo={handleRemoveRepo} repo={repo} />
      ))}
    </Container>
  );
}

export default App;
