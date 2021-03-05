package com.israel.libros.model.repositories;

import com.israel.libros.model.entities.User;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface UserRepository extends CrudRepository<User, Integer> {
    public User findByUsername(String username);
    public User findByUsernameAndPassword(String username, String password);
}
