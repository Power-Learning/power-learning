﻿using System;
using System.Collections;
using UnityEngine;

namespace LearningPattern.Command
{
    /// <summary>
    /// This class it's the client for CommandProcessor
    /// that consumes the Command pattern actions.
    /// Also moves an entity like a RTS game
    /// </summary>
    
    [RequireComponent(typeof(CommandProcessor))]
    [RequireComponent(typeof(ClickInputReader))]
    public class ClickToMoveEntity : MonoBehaviour, IEntity
    {
        private CommandProcessor _commandProcessor;
        private ClickInputReader _clickInputReader;
        private Coroutine _coroutine;

        private void Awake()
        {
            _commandProcessor = GetComponent<CommandProcessor>();
            _clickInputReader = GetComponent<ClickInputReader>();
        }

        private void Update()
        {
            var position = _clickInputReader.GetClickPosition();
            if(position != null)
                _commandProcessor.ExecuteCommand(new MoveToCommand(this, position.Value));
            
            if(Input.GetKeyDown(KeyCode.Backspace))
                _commandProcessor.Undo();
        }

        public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
        {
            if(_coroutine != null)
                StopCoroutine(_coroutine);

            _coroutine = StartCoroutine(MoveFromToAsync(startPosition, endPosition));
        }

        private IEnumerator MoveFromToAsync(Vector3 startPosition, Vector3 endPosition)
        {
            float elapsed = 0f;
            while (elapsed < 1f)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, elapsed);
                elapsed += Time.deltaTime;
                yield return null;
            }

            transform.position = endPosition;
        }
    }
}